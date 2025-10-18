This package contains generated interop structs for selected Windows types (e.g., _EPROCESS).

Files under `Generated/` are produced by the `ntoskrnlib` generator from PDB symbols on a Windows host.

To refresh locally:
- Build the generator: `dotnet build ntoskrnlib -c Release`
- Generate: `dotnet run --project ntoskrnlib -- -m %SystemRoot%\System32\ntoskrnl.exe -t _EPROCESS --flatten -o ntoskrnlib.Types\Generated`

