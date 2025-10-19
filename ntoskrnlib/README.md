This package contains generated interop structs for selected Windows types (e.g., _EPROCESS).

Files under `Generated/` are produced by the `ntoskrnlib.Generator` CLI from PDB symbols on a Windows host.

To refresh locally (PowerShell, Windows):
- Build the generator: `dotnet build ..\ntoskrnlib.Generator\ntoskrnlib.Generator.csproj -c Release`
- Generate: `dotnet run --project ..\ntoskrnlib.Generator\ntoskrnlib.Generator.csproj -- -m $env:SystemRoot\System32\ntoskrnl.exe -t _EPROCESS --flatten -o Generated`
