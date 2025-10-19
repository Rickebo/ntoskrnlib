# ntoskrnlib

Interop types for Windows kernel/user structures generated from PDB symbols, plus a generator CLI that produces strongly-typed C# layouts using Roslyn.

- Library (NuGet): `ntoskrnlib` (netstandard2.0) — contains the generated `struct` definitions.
- Generator (CLI): `ntoskrnlib.Generator` — Windows‑only tool that reads PDBs via DbgHelp/DIA and emits C# with `StructLayout(LayoutKind.Explicit)` and `FieldOffset` attributes.

## Prerequisites
- Windows 10/11 or Windows Server (for running the generator).
- .NET SDK 9.x (builds generator and library).
- Symbols access (recommended): set `_NT_SYMBOL_PATH` so DbgHelp can resolve PDBs, for example:
  - `srv*C:\Symbols*https://msdl.microsoft.com/download/symbols`
- Optional DIA fallback: Visual Studio 2022 (or Build Tools) with DIA SDK. If needed, register once (Admin PowerShell):
  - `regsvr32 "C:\\Program Files (x86)\\Microsoft Visual Studio\\2022\\BuildTools\\DIA SDK\\bin\\amd64\\msdia140.dll"`

Notes
- The generator is Windows‑only due to DbgHelp/DIA. The `ntoskrnlib` library itself targets netstandard2.0 and is portable.

## Project Structure
- `ntoskrnlib/` — generator CLI (project: `ntoskrnlib.Generator.csproj`).
  - Uses DbgHelp and DIA to inspect types and Roslyn (Microsoft.CodeAnalysis) to emit source.
- `ntoskrnlib.Types/` — library package (project: `ntoskrnlib.csproj`).
  - Includes `Generated/` with `*.g.cs` produced by the generator.
- `config/types.yml` — high‑level config listing modules and type names to generate.
- `.github/workflows/generate-types.yml` — CI workflow to generate types, version, pack, publish, and commit generated code.
- `ntoskrnlib.sln` — Visual Studio solution containing both projects.

## How It Works (high level)
1. The generator opens the target module (e.g., `ntoskrnl.exe`) and resolves its PDB symbols using DbgHelp; DIA is used as a fallback for certain queries.
2. For each UDT requested, it gathers fields/offsets/sizes and builds a Roslyn syntax tree for a C# `struct` with explicit layout.
3. Files are written to `ntoskrnlib.Types/Generated/*.g.cs` and compiled as part of the `ntoskrnlib` library.

## Quick Start (Windows)
- Build the generator:
  - `dotnet build ntoskrnlib\ntoskrnlib.Generator.csproj -c Release`
- Generate with the provided config into the library’s `Generated` folder:
  - `dotnet run --project ntoskrnlib\ntoskrnlib.Generator.csproj -- --config config\types.yml -o ntoskrnlib.Types\Generated`
- Or generate ad‑hoc types:
  - `dotnet run --project ntoskrnlib\ntoskrnlib.Generator.csproj -- -m C:\\Windows\\System32\\ntoskrnl.exe -t _EPROCESS,_EPARTITION --flatten -o ntoskrnlib.Types\Generated`

## Pack and (Optionally) Publish
- Build the library (so pack can skip rebuilding):
  - `dotnet build ntoskrnlib.Types\ntoskrnlib.csproj -c Release`
- Pack with your desired version:
  - `dotnet pack ntoskrnlib.Types\ntoskrnlib.csproj -c Release --no-build -o artifacts /p:PackageVersion=1.2.3`
- Publish to NuGet (requires an API key):
  - `dotnet nuget push artifacts\ntoskrnlib.1.2.3.nupkg --api-key <NUGET_API_KEY> --source https://api.nuget.org/v3/index.json --skip-duplicate`

Tip: Use `--no-build` on `dotnet pack` after you’ve already built to avoid re‑invoking the build step that may clear `Generated/` locally.

## CI/CD (GitHub Actions)
- Triggers: push to `master` (excluding `ntoskrnlib.Types/Generated/**`), manual dispatch, and a daily cron at 06:00 UTC.
- Versioning:
  - Uses `convco` (Conventional Commits) to decide major/minor bumps for push events based on commit messages.
  - Automatically increments the patch when the newly built `ntoskrnlib.dll` differs from the latest published NuGet version.
  - Manual dispatch can optionally provide an explicit version to publish.
- Publishing:
  - Packs and publishes only when content changed and `NUGET_API_KEY` is set in repo secrets.
  - Commits the updated `ntoskrnlib.Types/Generated` back to the repo and tags the commit (`vX.Y.Z`).

## Troubleshooting
- Symbols won’t download:
  - Verify `_NT_SYMBOL_PATH` and outbound network. Try the Microsoft symbol server URL shown above.
- DIA not found:
  - Either install VS 2022 Build Tools or skip DIA (DbgHelp handles many cases). The workflow attempts best‑effort registration on the runner.
- No files generated:
  - Check `config/types.yml` paths and type names. For ad‑hoc runs, confirm the module path and that the PDB exists on the symbol path.

## Contributing
- The generator code uses Roslyn’s `SyntaxFactory` rather than string concatenation; keep contributions in that style.
- The library’s `Generated/` content is source‑controlled for easy browsing; edits there will be overwritten by the generator.

