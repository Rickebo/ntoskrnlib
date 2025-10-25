# Code Generator Issues - Managed Classes

## Summary
The managed class generator (`.managed.g.cs` files) produces **2,052 compilation errors** across multiple files. These errors prevent the package from building when managed classes are included.

## Current Status
- ✅ **Unmanaged structs (*.g.cs)**: 2,411 files compile successfully
- ❌ **Managed wrappers (*.managed.g.cs)**: 1,229 files have syntax errors

## Build Configuration
As of the latest commit, the build is configured to **include all generated files** and will **fail if there are syntax errors**. This exposes generator bugs rather than silently excluding broken code.

```xml
<!-- ntoskrnlib/ntoskrnlib.csproj -->
<ItemGroup>
  <Compile Include="Generated\**\*.g.cs" />
</ItemGroup>
```

## Common Error Patterns

### 1. Invalid `void[]` Array Type
**Error**: `CS1519: Invalid token '[' in class, record, struct, or interface member declaration`

**Example** (AdapterObject.managed.g.cs:47):
```csharp
[Offset(256UL)]
public void[] CrashDumpRegisterBase { get; set; }  // ❌ void[] is invalid
```

**Root cause**: Generator emits `void[]` for pointer types it can't resolve.

### 2. Malformed Property Declarations
**Error**: `CS1001: Identifier expected`

**Example**: Properties missing type names or with invalid syntax.

### 3. Namespace Scope Issues
**Error**: `CS0116: A namespace cannot directly contain members such as fields, methods or statements`

**Example**: Code outside class declarations.

## Affected Files (Sample)
- `AdapterObject.managed.g.cs`
- `DeviceMap.managed.g.cs`
- `HandleTable.managed.g.cs`
- `MiVisibleState.managed.g.cs`
- `MiPoolState.managed.g.cs`
- `MiSystemPteState.managed.g.cs`
- `MiProcessState.managed.g.cs`
- `XsaveFormat.managed.g.cs`
- And 1,221 more files...

## Error Statistics
- **Total errors**: 2,052
- **Files affected**: ~1,229 files
- **Primary error codes**:
  - CS1519: Invalid token
  - CS1001: Identifier expected
  - CS0116: Invalid namespace member
  - CS1022: Type or namespace definition expected

## Recommendations

### Option 1: Fix the Generator (Recommended)
Update `ntoskrnlib.Generator` to:
1. Handle pointer types correctly (avoid `void[]`)
2. Generate valid property syntax
3. Ensure proper class/namespace structure
4. Add unit tests for generated code compilation

### Option 2: Exclude Managed Classes (Current Workaround)
Modify `ntoskrnlib.csproj` to exclude managed classes:
```xml
<Compile Include="Generated\**\*.g.cs" Exclude="Generated\**\*.managed.g.cs" />
```

**Result**: Package builds successfully with 2,411 unmanaged struct types (188.5 KB DLL).

### Option 3: Generate Only Unmanaged Structs
Configure the generator to skip managed wrapper generation entirely.

## Testing
To reproduce:
```bash
cd ntoskrnlib
dotnet build ntoskrnlib.csproj -c Release -p:SkipGenerateTypes=true
```

Expected result: Build fails with 2,052 errors from managed classes.

To build successfully (workaround):
```xml
<!-- Use Option 2 above in ntoskrnlib.csproj -->
```

## Package Impact
| Configuration | DLL Size | Types Included | Build Status |
|--------------|----------|----------------|--------------|
| Unmanaged only | 188.5 KB | 2,411 structs | ✅ Success |
| With managed classes | N/A | Would be ~3,640 types | ❌ Fails (2,052 errors) |
| Old (broken) | 94.5 KB | 0 types | ✅ Built but empty |
