# GitHub Workflow Changes - Compilation Enforcement

## Summary
The workflow has been updated to **enforce that all generated code compiles** before creating packages. The test stage now acts as a compilation gate.

## Changes Made

### 1. Test Stage Now Validates Compilation
**File**: `.github/workflows/generate-types.yml`

**Before**: Only built test project (didn't generate or validate main library)
```yaml
- name: Build test project
  run: dotnet build ntoskrnlib.Tests/ntoskrnlib.Tests.csproj -c Release --no-restore
```

**After**: Generates types, compiles main library, then runs tests
```yaml
- name: Generate types from config
  shell: pwsh
  run: |
    dotnet run --project ntoskrnlib.Generator -- `
      --config config/types.yml `
      --out ntoskrnlib/Generated `
      --winver "${{ env.WINVER_LABEL }}"

- name: Build main library (COMPILATION CHECK)
  run: dotnet build ntoskrnlib\ntoskrnlib.csproj -c Release /p:SkipGenerateTypes=true

- name: Build test project
  run: dotnet build ntoskrnlib.Tests/ntoskrnlib.Tests.csproj -c Release --no-restore

- name: Run tests
  run: dotnet test ntoskrnlib.Tests/ntoskrnlib.Tests.csproj -c Release --no-build
```

### 2. Project Configuration Includes All Generated Files
**File**: `ntoskrnlib/ntoskrnlib.csproj`

**Before**: Excluded managed classes (silently hiding generator bugs)
```xml
<Compile Include="Generated\**\*.g.cs" Exclude="Generated\**\*.managed.g.cs" />
```

**After**: Includes all generated files (exposes generator bugs)
```xml
<!-- Include all generated files (unmanaged structs and managed wrappers) -->
<!-- Build will fail if any generated files have syntax errors, forcing us to fix the generator -->
<ItemGroup>
  <Compile Include="Generated\**\*.g.cs" />
</ItemGroup>
```

## Workflow Stages

### Current Flow:
```
┌─────────────┐
│   Version   │ - Computes package version
└──────┬──────┘
       │
       v
┌─────────────────────────────────┐
│   Test (COMPILATION CHECK)      │
│  1. Generate ALL types          │
│  2. Build main library          │ ⟵ FAILS if compilation errors
│  3. Build test project          │
│  4. Run tests                   │
└──────┬──────────────────────────┘
       │ (only proceeds if compilation successful)
       v
┌─────────────────────────────────┐
│   Build                         │
│  1. Re-generate types           │
│  2. Build library               │
│  3. Create NuGet package        │
│  4. Validate package contents   │
└──────┬──────────────────────────┘
       │
       v
┌─────────────────────────────────┐
│   Publish                       │
│  - Push to NuGet.org            │
└─────────────────────────────────┘
```

## Current Build Status

### ⚠️ **BUILD WILL FAIL**

With managed classes included, the workflow will fail at the test stage with:
- **2,052 compilation errors**
- **1,229 files affected**

### Example Error:
```
C:\...\AdapterObject.managed.g.cs(47,20): error CS1519: Invalid token '[' in class, record, struct, or interface member declaration

Line 47: public void[] CrashDumpRegisterBase { get; set; }
                   ^^^^^^ Invalid syntax
```

## Next Steps

### Option 1: Fix the Generator (Recommended)
Update `ntoskrnlib.Generator` to produce valid C# code for managed classes.

**Tasks:**
- [ ] Fix `void[]` array type generation (use `IntPtr` or proper types)
- [ ] Fix property declaration syntax
- [ ] Fix namespace/class scope issues
- [ ] Add generator unit tests
- [ ] Add compilation tests for generated code

### Option 2: Temporary Workaround (Until Generator Fixed)
Revert `ntoskrnlib.csproj` to exclude managed classes:
```xml
<Compile Include="Generated\**\*.g.cs" Exclude="Generated\**\*.managed.g.cs" />
```

**Result:**
- ✅ Build succeeds
- ✅ Package created with 2,411 unmanaged structs (188.5 KB)
- ⚠️ Managed wrapper classes excluded
- ⚠️ Generator bugs remain hidden

### Option 3: Disable Managed Class Generation
Configure the generator to skip managed wrapper generation entirely.

## Impact

| Configuration | Test Stage | Package Created | Types Included |
|--------------|------------|-----------------|----------------|
| **Current (all files)** | ❌ Fails | ❌ No | N/A |
| **Exclude managed** | ✅ Passes | ✅ Yes | 2,411 structs (188.5 KB) |
| **Old (broken)** | ✅ Passed | ✅ Yes | 0 types (94.5 KB) |

## Testing Locally

To reproduce the current build failure:
```bash
cd ntoskrnlib
dotnet build ntoskrnlib.csproj -c Release -p:SkipGenerateTypes=true
```

Expected: Build fails with 2,052 errors from managed classes.

## Documentation
- See [GENERATOR_ISSUES.md](GENERATOR_ISSUES.md) for detailed error analysis
- See [ntoskrnlib.csproj](ntoskrnlib/ntoskrnlib.csproj) for current configuration
