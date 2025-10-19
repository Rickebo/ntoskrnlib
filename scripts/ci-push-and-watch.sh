#!/usr/bin/env bash
set -euo pipefail

# Push current branch to origin with force-with-lease and monitor GitHub Actions
# Usage:
#   GH_PAT=... scripts/ci-push-and-watch.sh [branch]
# If GH_PAT is not set, attempts SSH push first. For HTTPS, GH_PAT is required.

OWNER="Rickebo"
REPO="ntoskrnlib"
BRANCH="${1:-$(git rev-parse --abbrev-ref HEAD)}"

have_cmd() { command -v "$1" >/dev/null 2>&1; }

echo "Branch: $BRANCH"

push_with_ssh() {
  echo "Attempting SSH push (force-with-lease)..."
  if git push --force-with-lease origin "$BRANCH"; then
    echo "SSH push succeeded"; return 0
  else
    echo "SSH push failed (expected if no key)"; return 1
  fi
}

push_with_pat() {
  : "${GH_PAT:?Environment variable GH_PAT must be set for HTTPS push}"
  echo "Attempting HTTPS push with ephemeral header (force-with-lease)..."
  # Build Basic header for x-access-token
  if have_cmd base64; then
    if base64 --help 2>&1 | grep -q "-w"; then
      B64=$(printf "x-access-token:%s" "$GH_PAT" | base64 -w0)
    else
      # macOS BSD base64
      B64=$(printf "x-access-token:%s" "$GH_PAT" | base64)
    fi
  else
    echo "base64 not found; cannot form HTTP auth header" >&2; return 1
  fi
  git -c http.extraheader="AUTHORIZATION: basic $B64" \
      push --force-with-lease \
      https://github.com/${OWNER}/${REPO}.git \
      ${BRANCH}:${BRANCH}
}

if ! push_with_ssh; then
  push_with_pat
fi

echo "Push done. Monitoring latest workflow run..."

API_BASE="https://api.github.com/repos/${OWNER}/${REPO}"

fetch_json() {
  local url="$1"
  if [[ -n "${GH_PAT:-}" ]]; then
    curl -fsSL -H "Authorization: Bearer ${GH_PAT}" -H "Accept: application/vnd.github+json" "$url"
  else
    curl -fsSL -H "Accept: application/vnd.github+json" "$url"
  fi
}

get_latest_run_id() {
  fetch_json "$API_BASE/actions/runs?per_page=1" | sed -n 's/.*"id"\s*:\s*\([0-9][0-9]*\).*/\1/p' | head -n1
}

get_run_status() {
  local id="$1"
  fetch_json "$API_BASE/actions/runs/$id" | tr -d '\n' | sed -n 's/.*"status"\s*:\s*"\([^"]*\)".*/\1/p'
}

get_run_conclusion() {
  local id="$1"
  fetch_json "$API_BASE/actions/runs/$id" | tr -d '\n' | sed -n 's/.*"conclusion"\s*:\s*"\([^"]*\)".*/\1/p'
}

get_logs_url() {
  local id="$1"
  fetch_json "$API_BASE/actions/runs/$id" | tr -d '\n' | sed -n 's/.*"logs_url"\s*:\s*"\([^"]*\)".*/\1/p'
}

RUN_ID=""
echo -n "Waiting for run to appear"; for i in $(seq 1 60); do
  RUN_ID=$(get_latest_run_id || true)
  if [[ -n "$RUN_ID" ]]; then echo " => $RUN_ID"; break; fi
  echo -n "."; sleep 2
done
if [[ -z "$RUN_ID" ]]; then echo "\nNo workflow run found after push"; exit 1; fi

while :; do
  STATUS=$(get_run_status "$RUN_ID" || true)
  CONC=$(get_run_conclusion "$RUN_ID" || true)
  echo "Run $RUN_ID: status=$STATUS conclusion=${CONC:-<none>}" | sed 's/\s\+/ /g'
  if [[ "$STATUS" == "completed" ]]; then
    break
  fi
  sleep 10
done

if [[ "${CONC:-failure}" == "success" ]]; then
  echo "Workflow succeeded ✅"
  exit 0
fi

echo "Workflow failed ❌ — downloading logs"
LOGS_URL=$(get_logs_url "$RUN_ID" || true)
if [[ -n "$LOGS_URL" ]]; then
  ZIP="/tmp/${REPO}-logs-$RUN_ID.zip"
  if [[ -n "${GH_PAT:-}" ]]; then
    curl -fsSL -H "Authorization: Bearer ${GH_PAT}" "$LOGS_URL" -o "$ZIP" || true
  else
    curl -fsSL "$LOGS_URL" -o "$ZIP" || true
  fi
  echo "Logs saved to $ZIP"
else
  echo "No logs_url available"
fi

exit 2

