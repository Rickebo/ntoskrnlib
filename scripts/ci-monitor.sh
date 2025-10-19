#!/usr/bin/env bash
set -euo pipefail
OWNER="Rickebo"
REPO="ntoskrnlib"
API_BASE="https://api.github.com/repos/${OWNER}/${REPO}"

fetch_json() { curl -fsSL -H "Accept: application/vnd.github+json" "$1"; }

get_latest_run_id() { fetch_json "$API_BASE/actions/runs?per_page=1" | sed -n 's/.*"id"\s*:\s*\([0-9][0-9]*\).*/\1/p' | head -n1; }
get_run_status() { local id="$1"; fetch_json "$API_BASE/actions/runs/$id" | tr -d '\n' | sed -n 's/.*"status"\s*:\s*"\([^"]*\)".*/\1/p'; }
get_run_conclusion() { local id="$1"; fetch_json "$API_BASE/actions/runs/$id" | tr -d '\n' | sed -n 's/.*"conclusion"\s*:\s*"\([^"]*\)".*/\1/p'; }

echo -n "Waiting for latest run"; for i in $(seq 1 60); do
  RUN_ID=$(get_latest_run_id || true)
  if [[ -n "${RUN_ID:-}" ]]; then echo " => $RUN_ID"; break; fi
  echo -n "."; sleep 2
done
[[ -n "${RUN_ID:-}" ]] || { echo "\nNo runs found"; exit 1; }

while :; do
  STATUS=$(get_run_status "$RUN_ID" || true)
  CONC=$(get_run_conclusion "$RUN_ID" || true)
  echo "Run $RUN_ID: status=$STATUS conclusion=${CONC:-<none>}" | sed 's/\s\+/ /g'
  if [[ "$STATUS" == "completed" ]]; then
    test "${CONC:-failure}" = success && exit 0 || exit 2
  fi
  sleep 10
done

