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
- `ntoskrnlib.Generator/` — generator CLI (project: `ntoskrnlib.Generator.csproj`).
  - Uses DbgHelp and DIA to inspect types and Roslyn (Microsoft.CodeAnalysis) to emit source.
- `ntoskrnlib/` — library package (project: `ntoskrnlib.csproj`).
  - Includes `Generated/` with `*.g.cs` produced by the generator.
- `config/types.yml` — high‑level config listing modules and type names to generate.
- `ntoskrnlib.sln` — solution containing both projects.

## How It Works (high level)
1. The generator opens the target module (e.g., `ntoskrnl.exe`) and resolves its PDB symbols using DbgHelp; DIA is used as a fallback for certain queries.
2. For each UDT requested, it gathers fields/offsets/sizes and builds a Roslyn syntax tree for a C# `struct` with explicit layout.
3. Files are written to `ntoskrnlib/Generated/*.g.cs` and compiled as part of the `ntoskrnlib` library.

## Quick Start (Windows)
- Build the generator:
  - `dotnet build ntoskrnlib.Generator\ntoskrnlib.Generator.csproj -c Release`
- Generate with the provided config into the library’s `Generated` folder:
  - `dotnet run --project ntoskrnlib.Generator\ntoskrnlib.Generator.csproj -- --config config\types.yml -o ntoskrnlib\Generated`
- Or generate ad‑hoc types:
  - `dotnet run --project ntoskrnlib.Generator\ntoskrnlib.Generator.csproj -- -m C:\\Windows\\System32\\ntoskrnl.exe -t _EPROCESS,_EPARTITION --flatten -o ntoskrnlib\Generated`

## Pack and (Optionally) Publish
- Build the library (auto-generates sources during build on Windows):
  - `dotnet build ntoskrnlib\ntoskrnlib.csproj -c Release`
- Pack with your desired version (builds and generates by default):
  - `dotnet pack ntoskrnlib\ntoskrnlib.csproj -c Release -o artifacts /p:PackageVersion=1.2.3`
- Publish to NuGet (requires an API key):
  - `dotnet nuget push artifacts\ntoskrnlib.1.2.3.nupkg --api-key <NUGET_API_KEY> --source https://api.nuget.org/v3/index.json --skip-duplicate`

Tip: Use `--no-build` on `dotnet pack` after you’ve already built to avoid re‑invoking the build step that may clear `Generated/` locally.
Note: Generation is now wired into the library build. If you want to skip it (e.g., CI restoring cached sources), use `-p:SkipGenerateTypes=true` or set `GenerateTypesDuringBuild=false` in an MSBuild response/props file.

## CI/CD (GitHub Actions)
- Triggers: push to `master` (excluding `ntoskrnlib/Generated/**`), manual dispatch, and a daily cron at 06:00 UTC.
- Versioning:
  - Uses `convco` (Conventional Commits) to decide major/minor bumps for push events based on commit messages.
  - Automatically increments the patch when the newly built `ntoskrnlib.dll` differs from the latest published NuGet version.
  - Manual dispatch can optionally provide an explicit version to publish.
- Publishing:
  - Packs and publishes only when content changed and `NUGET_API_KEY` is set in repo secrets.
  - Commits the updated `ntoskrnlib/Generated` back to the repo and tags the commit (`vX.Y.Z`).

## CLI Reference
The generator uses System.CommandLine and prints rich `--help` output. All options are optional unless marked required.

- `-m, --module <path>`
  - Path to the module (EXE/DLL) whose PDB symbols to use.
  - Default: `C:\\Windows\\System32\\ntoskrnl.exe`.
- `-t, --types <name> [<name>...]`
  - One or more type names to generate. You can repeat the option or comma‑separate the names, e.g. `-t _EPROCESS,_EPARTITION` or `-t _EPROCESS -t _EPARTITION`.
- `-a, --all`
  - Generate all UDTs in the specified module.
- `-o, --out <dir>`
  - Output directory for generated `*.g.cs` files.
  - Default: `./out` (current directory).
- `--flatten`
  - Flatten nested UDTs into inline `byte[]` fields with `[MarshalAs(ByValArray)]`, useful for single‑file structs.
- `-d, --deps`
  - When not flattening, also emit dependent UDTs referenced by fields.
- `-c, --config <file>`
  - YAML config listing modules/types to generate. When provided, this mode processes the file and overrides other selectors.

Notes
- If you don’t specify `--types`, `--all`, or `--config`, the tool defaults to generating `_EPROCESS` with `--flatten` for a quick start.
- When a type cannot be resolved via DbgHelp, the tool falls back to DIA automatically (in both direct and config modes) when available.

## Config File (--config)
The `--config` option accepts a YAML file that defines one or more generation batches. The generator processes entries in order and writes the output for each into the `-o` directory you pass (or the default `./out` if you run the generator directly).

Schema
- Root key: `types` (array of entries)
- Entry fields:
  - `module` (string, required): Full path to the module (EXE/DLL) whose PDB should be used.
  - `flatten` (bool, optional): If true, nested UDTs are emitted as inline `byte[]` so the root struct stays single‑file. Defaults to false.
  - `all` (bool, optional): When true, generate all UDTs found in the module (overrides `names`).
  - `names` (string list, optional): One or more UDT display names to generate (e.g., `_EPROCESS`, `_PEB`). Ignored when `all: true`.

Example
```yaml
types:
  - module: C:\\Windows\\System32\\ntoskrnl.exe
    flatten: true
    names: [ _EPROCESS ]
  - module: C:\\Windows\\System32\\ntdll.dll
    flatten: false
    names: [ _PEB, _UNICODE_STRING, _LIST_ENTRY ]
  - module: C:\\Windows\\System32\\ntoskrnl.exe
    all: true              # dump entire module
    flatten: false         # emit dependencies as real UDTs
```

Behavior notes
- Dependencies: when `flatten: false`, referenced UDTs are also emitted (breadth‑first) so the root types compile; when `flatten: true`, referenced UDT fields are emitted as inline `byte[]` and dependencies are not traversed.
- Symbol resolution: in config mode the generator uses DbgHelp first; if a type can’t be found, it automatically falls back to DIA (when available).
- Placeholder in CI: the workflow may use a placeholder module path (like `ntoskrnlib_placeholder.exe`) that the job step rewrites to `ntoskrnl.exe` before running. For local runs you can point `module` directly at the real path.

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
