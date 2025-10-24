# AI Agent Guide: ntoskrnlib

**Last Updated:** 2025-10-24
**Project Version:** Based on master branch (f44c355)

This document provides AI agents with a comprehensive guide to understanding, navigating, and contributing to the ntoskrnlib repository.

---

## Table of Contents

1. [Project Overview](#project-overview)
2. [Quick Reference Map](#quick-reference-map)
3. [Key Concepts & Terminology](#key-concepts--terminology)
4. [Architecture Deep Dive](#architecture-deep-dive)
5. [File Navigation Guide](#file-navigation-guide)
6. [Common Development Tasks](#common-development-tasks)
7. [Code Generation Pipeline](#code-generation-pipeline)
8. [Runtime Usage Patterns](#runtime-usage-patterns)
9. [Extension Points](#extension-points)
10. [CI/CD Pipeline](#cicd-pipeline)
11. [Troubleshooting Guide](#troubleshooting-guide)
12. [References & Resources](#references--resources)

---

## Project Overview

### Purpose

**ntoskrnlib** is a Windows-specific code generation tool that creates strongly-typed C# interop structures from PDB (Program Debug Database) symbols found in Windows kernel and system libraries (ntoskrnl.exe, ntdll.dll, etc.).

### Primary Goals

1. **Bridge C# and Windows Internals**: Provide type-safe access to kernel structures
2. **Automate Interop Code**: Generate thousands of structure definitions automatically
3. **Track Windows Changes**: Version-specific type definitions (Win25H2, etc.)
4. **Runtime Flexibility**: Support both static and dynamic structure access patterns

### Two-Part Architecture

| Component | Platform | Framework | Purpose |
|-----------|----------|-----------|---------|
| **Generator** | Windows-only | .NET 9.0 | CLI tool that reads PDB symbols and emits C# code |
| **Library** | Cross-platform | .NET Standard 2.0 | NuGet package with generated types + runtime helpers |

### Target Audience

- Windows internals developers
- Security researchers
- Kernel driver developers
- System diagnostic tool authors
- Anyone needing programmatic access to Windows kernel structures

---

## Quick Reference Map

### Directory Structure

```
ntoskrnlib/
│
├── ntoskrnlib/                          # Main library (netstandard2.0)
│   ├── Structure/                       # Runtime helper classes
│   │   ├── MemoryPointer.cs            # ⭐ Pointer arithmetic wrapper
│   │   ├── DynamicStructure.cs         # ⭐ Base class for dynamic structures
│   │   ├── DynamicArray.cs             # Array marshaling helper
│   │   ├── DynamicStructureService.cs  # Factory for reading structures
│   │   └── IMemorySource.cs            # Memory access abstraction
│   └── Generated/                       # ⚙️ Output folder (auto-generated)
│       └── Win25H2/
│           ├── nt/                     # ntoskrnl.exe types
│           └── ntdll/                  # ntdll.dll types
│
├── ntoskrnlib.Generator/               # ⭐ Code generator (net9.0)
│   ├── Program.cs                      # 🔹 Entry point + CLI setup
│   ├── Gen/
│   │   ├── CodeGenerator.cs           # 🔹 Roslyn-based struct emitter
│   │   ├── TypeInspector.cs           # 🔹 DbgHelp type queries
│   │   ├── UdtEmitter.cs              # 🔹 File writer
│   │   ├── DynamicWrapperGenerator.cs # Dynamic structure wrapper generator
│   │   ├── DiaInspector.cs            # DIA SDK fallback
│   │   └── DiaEmitter.cs              # DIA-based code generation
│   ├── Symbols/
│   │   └── SymbolSession.cs           # 🔹 DbgHelp session management
│   ├── Interop/
│   │   └── DbgHelp.cs                 # 🔹 P/Invoke bindings
│   ├── Services/                       # DI factory services
│   ├── Abstractions/                   # Factory interfaces
│   └── Options/
│       └── GenerationOptions.cs       # CLI option container
│
├── samples/
│   └── StructureDemo/                  # 📚 Example application
│       ├── Program.cs                  # Demo entry point
│       ├── DemoStruct.cs              # Reflection-based example
│       ├── DemoStructZeroReflection.cs # Offset-map example
│       └── SimpleMemorySource.cs      # Test memory implementation
│
├── config/
│   └── types.yml                       # ⚙️ Generator configuration
│
├── .github/workflows/
│   └── generate-types.yml             # 🔹 CI/CD pipeline
│
├── ntoskrnlib.sln                      # Solution file
└── README.md                           # User documentation
```

**Legend:**
- ⭐ = Critical component
- 🔹 = Important file for understanding the project
- ⚙️ = Configuration/generated content
- 📚 = Learning resource

### Key Files Quick Reference

| Task | Start Here | Key Dependencies |
|------|------------|------------------|
| **Understand code generation** | [ntoskrnlib.Generator/Program.cs](ntoskrnlib.Generator/Program.cs) | [Gen/CodeGenerator.cs](ntoskrnlib.Generator/Gen/CodeGenerator.cs), [Gen/TypeInspector.cs](ntoskrnlib.Generator/Gen/TypeInspector.cs) |
| **Add CLI options** | [Options/GenerationOptions.cs](ntoskrnlib.Generator/Options/GenerationOptions.cs) | [Program.cs](ntoskrnlib.Generator/Program.cs) |
| **Symbol loading logic** | [Symbols/SymbolSession.cs](ntoskrnlib.Generator/Symbols/SymbolSession.cs) | [Interop/DbgHelp.cs](ntoskrnlib.Generator/Interop/DbgHelp.cs) |
| **Type inspection** | [Gen/TypeInspector.cs](ntoskrnlib.Generator/Gen/TypeInspector.cs) | [Interop/DbgHelp.cs](ntoskrnlib.Generator/Interop/DbgHelp.cs) |
| **Code emission** | [Gen/CodeGenerator.cs](ntoskrnlib.Generator/Gen/CodeGenerator.cs) | [Gen/UdtEmitter.cs](ntoskrnlib.Generator/Gen/UdtEmitter.cs) |
| **Runtime structure access** | [Structure/DynamicStructure.cs](ntoskrnlib/Structure/DynamicStructure.cs) | [Structure/MemoryPointer.cs](ntoskrnlib/Structure/MemoryPointer.cs), [Structure/IMemorySource.cs](ntoskrnlib/Structure/IMemorySource.cs) |
| **Usage examples** | [samples/StructureDemo/Program.cs](samples/StructureDemo/Program.cs) | All samples/*.cs files |
| **Configuration** | [config/types.yml](config/types.yml) | N/A |
| **CI/CD** | [.github/workflows/generate-types.yml](.github/workflows/generate-types.yml) | N/A |

### Technology Stack

| Layer | Technologies |
|-------|-------------|
| **Language** | C# 13 (.NET 9.0 for generator, .NET Standard 2.0 for library) |
| **Code Generation** | Microsoft.CodeAnalysis.CSharp (Roslyn) 4.11.0 |
| **CLI** | System.CommandLine 2.0 |
| **DI/Logging** | Microsoft.Extensions.* 9.0.0 |
| **Config** | YamlDotNet 13.7.1 |
| **Windows APIs** | DbgHelp.dll (P/Invoke), DIA SDK (msdia140.dll) |
| **CI/CD** | GitHub Actions |
| **Package** | NuGet |

---

## Key Concepts & Terminology

### PDB Symbols

**Program Database (PDB)** files contain debugging symbols including:
- Structure layouts (field names, offsets, sizes)
- Type definitions (UDTs, enums, primitives)
- Function signatures

Windows ships PDB files for system binaries via the Microsoft Symbol Server. ntoskrnlib reads these PDB files to generate C# interop code.

### DbgHelp API

**DbgHelp.dll** is a Windows debugging library providing symbol manipulation functions:
- `SymInitialize` / `SymCleanup` - Session management
- `SymLoadModuleEx` - Load symbols from PDB
- `SymGetTypeFromName` - Lookup type by name
- `SymGetTypeInfo` - Query type properties (size, fields, etc.)

See: [Interop/DbgHelp.cs](ntoskrnlib.Generator/Interop/DbgHelp.cs) for P/Invoke bindings.

### DIA SDK

**Debug Interface Access (DIA)** SDK is an alternate COM-based API for symbol access:
- Fallback when DbgHelp fails or provides incomplete information
- Requires msdia140.dll registration (`regsvr32`)
- Used via [Gen/DiaInspector.cs](ntoskrnlib.Generator/Gen/DiaInspector.cs)

### UDT (User-Defined Type)

In PDB terminology, a **UDT** is any structure/class/union. Examples:
- `_EPROCESS` (kernel process structure)
- `_KTHREAD` (kernel thread structure)
- `_PEB` (Process Environment Block)

### Structure Flattening

**Flattening** means replacing nested UDT fields with inline `byte[]` arrays:

```csharp
// Without flattening (requires dependent type)
[FieldOffset(0x100)]
public _KPROCESS ProcessObject;

// With flattening
[FieldOffset(0x100)]
[MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x438)]
public byte[] ProcessObject;
```

Controlled by `--flatten` CLI flag or YAML `flatten: true`.

### Dynamic Structures

**DynamicStructure** is a runtime pattern for accessing structures without compile-time knowledge:

```csharp
// Static (compile-time)
var process = Marshal.PtrToStructure<_EPROCESS>(ptr);

// Dynamic (runtime)
var process = DynamicStructureService.Reads<Dynamic_EPROCESS>(memorySource, address);
var pid = process.ReadField<uint>("UniqueProcessId");
```

Enables versioning flexibility and lazy field access.

### Memory Pointer

**MemoryPointer** is a strongly-typed wrapper around `ulong` addresses:
- Supports arithmetic: `ptr + 0x10`, `ptr++`, `ptr - otherPtr`
- Comparisons: `ptr < otherPtr`, `ptr == otherPtr`
- Conversions: `(IntPtr)ptr`, `(UIntPtr)ptr`

See: [Structure/MemoryPointer.cs](ntoskrnlib/Structure/MemoryPointer.cs)

### Memory Source

**IMemorySource** abstracts memory access for different backends:
- Kernel memory (via driver)
- User-mode memory (ReadProcessMemory)
- Memory dumps (.dmp files)
- Test memory (byte arrays)

Example: [samples/StructureDemo/SimpleMemorySource.cs](samples/StructureDemo/SimpleMemorySource.cs)

---

## Architecture Deep Dive

### Generator Architecture

```
┌─────────────────────────────────────────────────────────────┐
│                      Program.cs (CLI Entry)                  │
│  - Parse arguments (System.CommandLine)                      │
│  - Setup DI container (Microsoft.Extensions.DependencyInjection)│
│  - Invoke GenerationRunner                                   │
└────────────────────┬────────────────────────────────────────┘
                     │
                     ▼
┌─────────────────────────────────────────────────────────────┐
│              Services/GenerationRunner.cs                    │
│  - Load config (types.yml)                                   │
│  - For each module:                                          │
│    • Create SymbolSession                                    │
│    • Create TypeInspector or DiaInspector                   │
│    • Create CodeGenerator or DiaCodeGenerator               │
│    • Generate requested types                               │
│    • Write files via UdtEmitter                             │
└────────────────────┬────────────────────────────────────────┘
                     │
        ┌────────────┼────────────┐
        │            │            │
        ▼            ▼            ▼
┌──────────────┐ ┌──────────────┐ ┌──────────────┐
│SymbolSession │ │TypeInspector │ │CodeGenerator │
│              │ │              │ │              │
│• SymInitialize│ │• GetTypeId  │ │• Roslyn AST │
│• SymLoadModule│ │• GetFields  │ │• Emit code  │
│• Symbol path │ │• GetSize    │ │• Attributes │
└──────┬───────┘ └──────┬───────┘ └──────┬───────┘
       │                │                │
       ▼                ▼                ▼
┌──────────────────────────────────────────┐
│         Interop/DbgHelp.cs              │
│  P/Invoke bindings to DbgHelp.dll       │
│  - SymGetTypeInfo, SymEnumFields, etc.  │
└──────────────────────────────────────────┘
```

### Dependency Injection Structure

The generator uses Microsoft.Extensions.DependencyInjection:

```csharp
// Registered services
services.AddSingleton<ISymbolSessionFactory, SymbolSessionFactory>();
services.AddSingleton<ICodeGeneratorFactory, CodeGeneratorFactory>();
services.AddSingleton<IUdtEmitterFactory, UdtEmitterFactory>();
services.AddSingleton<IDiaInspectorFactory, DiaInspectorFactory>();
services.AddSingleton<GenerationRunner>();
```

See: [Program.cs:38-59](ntoskrnlib.Generator/Program.cs#L38-L59)

### Library Architecture

```
┌─────────────────────────────────────────────────────────────┐
│                   Generated Structures                       │
│  Generated/Win25H2/nt/_EPROCESS.g.cs                        │
│  Generated/Win25H2/ntdll/_PEB.g.cs                          │
│  [StructLayout(LayoutKind.Explicit)] with [FieldOffset]     │
└────────────────────┬────────────────────────────────────────┘
                     │
                     ▼
┌─────────────────────────────────────────────────────────────┐
│              Dynamic Structure Wrappers                      │
│  Generated/Win25H2/nt/Dynamic/_EPROCESS.dynamic.g.cs        │
│  Inherits DynamicStructure, registers field offsets         │
└────────────────────┬────────────────────────────────────────┘
                     │
                     ▼
┌─────────────────────────────────────────────────────────────┐
│           Structure/DynamicStructure.cs                      │
│  - Static registry: Type → Field offsets                    │
│  - RegisterTypes(Assembly) for auto-discovery               │
│  - Register<T>(ctor, offsets) for manual registration       │
│  - Instance: BaseAddress + IMemorySource                    │
└────────────────────┬────────────────────────────────────────┘
                     │
        ┌────────────┼────────────┐
        │            │            │
        ▼            ▼            ▼
┌──────────────┐ ┌──────────────┐ ┌──────────────┐
│MemoryPointer│ │IMemorySource │ │DynamicArray  │
│              │ │              │ │              │
│• Arithmetic  │ │• Read()      │ │• Indexing    │
│• Comparisons │ │• Write()     │ │• Marshaling  │
│• Conversions │ │(Interface)   │ │              │
└──────────────┘ └──────────────┘ └──────────────┘
```

### Code Generation Pipeline

```
1. Parse CLI Options / Load YAML Config
                ↓
2. Create SymbolSession (DbgHelp)
   - Initialize symbol handler
   - Load module (ntoskrnl.exe, ntdll.dll)
   - Build symbol path from _NT_SYMBOL_PATH
                ↓
3. Create TypeInspector over session
   - Wrapper around DbgHelp API
   - Provides high-level type queries
                ↓
4. For each type to generate:
   ┌────────────────────────────────────┐
   │ a. Lookup typeId                   │
   │    TypeInspector.TryGetTypeIdByName│
   │    Tries: nt!_TYPE, ntkrnlmp!_TYPE │
   └──────────────┬─────────────────────┘
                  ▼
   ┌────────────────────────────────────┐
   │ b. Generate C# code                │
   │    CodeGenerator.GenerateUdt()     │
   │    - Roslyn AST builder            │
   │    - StructLayout(Explicit)        │
   │    - FieldOffset attributes        │
   │    - Type resolution               │
   └──────────────┬─────────────────────┘
                  ▼
   ┌────────────────────────────────────┐
   │ c. Generate Dynamic wrapper        │
   │    DynamicWrapperGenerator         │
   │    - .dynamic.g.cs file            │
   │    - DynamicStructure subclass     │
   │    - Static Register<T>() method   │
   └──────────────┬─────────────────────┘
                  ▼
   ┌────────────────────────────────────┐
   │ d. Handle dependencies (optional)  │
   │    - BFS enqueue dependent UDTs    │
   │    - Recursively generate          │
   └──────────────┬─────────────────────┘
                  ▼
5. Write all .cs files to output directory
   UdtEmitter.EmitUdts()
                ↓
6. Compile into library (MSBuild target)
   MSBuild invokes generator before build
                ↓
7. Package as NuGet
   dotnet pack
```

---

## File Navigation Guide

### Symbol Loading & Session Management

**Where:** [ntoskrnlib.Generator/Symbols/SymbolSession.cs](ntoskrnlib.Generator/Symbols/SymbolSession.cs)

**Key Methods:**
- `LoadModule(string modulePath)` - Loads a PE module and its PDB
- `Dispose()` - Cleanup DbgHelp session

**Usage Pattern:**
```csharp
using var session = new SymbolSession();
ulong baseAddress = session.LoadModule(@"C:\Windows\System32\ntoskrnl.exe");
```

### Type Inspection (DbgHelp)

**Where:** [ntoskrnlib.Generator/Gen/TypeInspector.cs](ntoskrnlib.Generator/Gen/TypeInspector.cs)

**Key Methods:**
- `TryGetTypeIdByName(string typeName, out uint typeId)` - Lookup type by name
- `GetUdtFields(uint typeId)` - Enumerate struct fields with offsets
- `GetTypeLength(uint typeId)` - Get structure size
- `GetTypeName(uint typeId)` - Get type name string

**Fallback Logic:**
The inspector tries multiple module name prefixes:
1. `nt!_EPROCESS`
2. `ntkrnlmp!_EPROCESS`
3. `ntkrnlpa!_EPROCESS`
4. `ntkrpamp!_EPROCESS`

See: [TypeInspector.cs:80-115](ntoskrnlib.Generator/Gen/TypeInspector.cs#L80-L115)

### Code Generation (Roslyn)

**Where:** [ntoskrnlib.Generator/Gen/CodeGenerator.cs](ntoskrnlib.Generator/Gen/CodeGenerator.cs)

**Key Methods:**
- `GenerateUdt(uint typeId, string typeName, GenerationOptions options)` - Main entry point
- `GenerateFields(uint typeId, bool flatten)` - Generate field declarations
- `ResolveType(uint fieldTypeId)` - Convert PDB type to C# type

**Output Structure:**
```csharp
namespace ntoskrnlib.Generated.Win25H2.nt
{
    [StructLayout(LayoutKind.Explicit, Size = 0xABC)]
    public struct _EPROCESS
    {
        [FieldOffset(0x0)]
        public _KPROCESS Pcb;

        [FieldOffset(0x2E8)]
        public uint UniqueProcessId;
        // ...
    }
}
```

### File Writing

**Where:** [ntoskrnlib.Generator/Gen/UdtEmitter.cs](ntoskrnlib.Generator/Gen/UdtEmitter.cs)

**Key Methods:**
- `EmitUdts(...)` - Main orchestrator for writing files
- Performs BFS traversal for dependency ordering
- Creates directory structure
- Writes both regular `.g.cs` and `.dynamic.g.cs` files

**Output Paths:**
- Regular: `Generated/Win25H2/nt/_EPROCESS.g.cs`
- Dynamic: `Generated/Win25H2/nt/Dynamic/_EPROCESS.dynamic.g.cs`

### Dynamic Wrapper Generation

**Where:** [ntoskrnlib.Generator/Gen/DynamicWrapperGenerator.cs](ntoskrnlib.Generator/Gen/DynamicWrapperGenerator.cs)

**Output Example:**
```csharp
namespace ntoskrnlib.Generated.Win25H2.nt.Dynamic
{
    public class Dynamic_EPROCESS : DynamicStructure
    {
        static Dynamic_EPROCESS()
        {
            Register<Dynamic_EPROCESS>(
                baseAddress => new Dynamic_EPROCESS { BaseAddress = baseAddress },
                new Dictionary<string, ulong>
                {
                    ["Pcb"] = 0x0,
                    ["UniqueProcessId"] = 0x2E8,
                    // ...
                }
            );
        }
    }
}
```

### Runtime: Memory Pointer

**Where:** [ntoskrnlib/Structure/MemoryPointer.cs](ntoskrnlib/Structure/MemoryPointer.cs)

**Key Features:**
- Wraps `ulong Value` property
- Arithmetic operators: `+`, `-`, `++`, `--`
- Comparison: `==`, `!=`, `<`, `>`, `<=`, `>=`
- Conversions: `IntPtr`, `UIntPtr`, `long`, `ulong`
- `Zero` constant and `IsZero` property

**Usage:**
```csharp
MemoryPointer ptr = new(0x7FFE0000);
ptr += 0x10; // Add offset
MemoryPointer next = ptr + 8;
long distance = next - ptr; // Pointer difference = 8
```

### Runtime: Dynamic Structures

**Where:** [ntoskrnlib/Structure/DynamicStructure.cs](ntoskrnlib/Structure/DynamicStructure.cs)

**Key Methods:**
- `RegisterTypes(Assembly assembly)` - Auto-discover and register all dynamic types
- `Register<T>(Func<MemoryPointer, T> factory, Dictionary<string, ulong> offsets)` - Manual registration
- `ReadField<T>(string fieldName)` - Read typed field value from memory
- `TryReadField<T>(...)` - Safe read with error handling

**Registration Patterns:**

**Automatic (Reflection-based):**
```csharp
// In application startup
DynamicStructure.RegisterTypes(Assembly.GetExecutingAssembly());
```

**Manual (Zero-reflection):**
```csharp
DynamicStructure.Register<MyStruct>(
    baseAddr => new MyStruct { BaseAddress = baseAddr },
    new Dictionary<string, ulong>
    {
        ["Field1"] = 0x00,
        ["Field2"] = 0x08
    }
);
```

See samples: [samples/StructureDemo/DemoStruct.cs](samples/StructureDemo/DemoStruct.cs) vs [samples/StructureDemo/DemoStructZeroReflection.cs](samples/StructureDemo/DemoStructZeroReflection.cs)

### Runtime: Memory Source

**Where:** [ntoskrnlib/Structure/IMemorySource.cs](ntoskrnlib/Structure/IMemorySource.cs)

**Interface:**
```csharp
public interface IMemorySource
{
    byte[] Read(MemoryPointer address, int length);
    void Write(MemoryPointer address, byte[] data);
}
```

**Example Implementation:** [samples/StructureDemo/SimpleMemorySource.cs](samples/StructureDemo/SimpleMemorySource.cs)

---

## Common Development Tasks

### Building the Project

**Prerequisites:**
- Windows 10/11 or Windows Server
- .NET SDK 9.x
- Visual Studio 2022 or Build Tools (for DIA SDK, optional)
- `_NT_SYMBOL_PATH` environment variable (optional, defaults to Microsoft symbol server)

**Build Commands:**

```bash
# Build entire solution
dotnet build ntoskrnlib.sln -c Release

# Build generator only
dotnet build ntoskrnlib.Generator/ntoskrnlib.Generator.csproj -c Release

# Build library only (auto-generates types on Windows)
dotnet build ntoskrnlib/ntoskrnlib.csproj -c Release

# Build without generation (faster for non-generation changes)
dotnet build ntoskrnlib/ntoskrnlib.csproj -c Release /p:SkipGenerateTypes=true

# Pack NuGet package
dotnet pack ntoskrnlib/ntoskrnlib.csproj -c Release -o artifacts
```

### Generating Types

**Single Type (Flattened):**
```bash
dotnet run --project ntoskrnlib.Generator -- \
  --module C:\Windows\System32\ntoskrnl.exe \
  --types _EPROCESS \
  --flatten \
  --output ntoskrnlib/Generated
```

**Multiple Types:**
```bash
dotnet run --project ntoskrnlib.Generator -- \
  -m C:\Windows\System32\ntoskrnl.exe \
  -t _EPROCESS,_KTHREAD,_PEB \
  -o ntoskrnlib/Generated
```

**All Types from Module:**
```bash
dotnet run --project ntoskrnlib.Generator -- \
  --module C:\Windows\System32\ntdll.dll \
  --all \
  --output ntoskrnlib/Generated
```

**Config-Driven Generation (Recommended):**
```bash
dotnet run --project ntoskrnlib.Generator -- \
  --config config/types.yml \
  --output ntoskrnlib/Generated \
  --winver Win25H2
```

**CLI Options Reference:**
- `-m, --module <path>` - Path to Windows module (exe/dll)
- `-t, --types <list>` - Comma-separated type names
- `--all` - Generate all types from module
- `--flatten` - Flatten nested structures to byte arrays
- `--emit-dynamic <bool>` - Generate Dynamic/* wrappers (default: true)
- `-o, --output <path>` - Output directory
- `-c, --config <path>` - YAML configuration file
- `--winver <label>` - Windows version label (e.g., Win25H2)

### Running Samples

```bash
# Navigate to sample directory
cd samples/StructureDemo

# Run the demo
dotnet run

# Expected output:
# - Reflection-based structure registration
# - Zero-reflection structure registration
# - Field reading demonstrations
# - Memory pointer arithmetic examples
```

**Key Sample Files:**
- [Program.cs](samples/StructureDemo/Program.cs) - Entry point, orchestrates demos
- [DemoStruct.cs](samples/StructureDemo/DemoStruct.cs) - Uses `[Offset]` attribute + reflection
- [DemoStructZeroReflection.cs](samples/StructureDemo/DemoStructZeroReflection.cs) - Explicit offset map, no reflection
- [SimpleMemorySource.cs](samples/StructureDemo/SimpleMemorySource.cs) - Byte array-based memory for testing

### Adding Types to Configuration

**Edit:** [config/types.yml](config/types.yml)

```yaml
types:
  # ntoskrnl.exe - All types, with dependencies
  - module: C:\Windows\System32\ntoskrnl.exe
    all: true
    flatten: false

  # ntdll.dll - All types, with dependencies
  - module: C:\Windows\System32\ntdll.dll
    all: true
    flatten: false

  # Custom module - Specific types, flattened
  - module: C:\Windows\System32\win32kbase.sys
    types:
      - _THREADINFO
      - _DESKTOPINFO
    flatten: true
```

After editing, run:
```bash
dotnet run --project ntoskrnlib.Generator -- -c config/types.yml -o ntoskrnlib/Generated
```

### Testing Changes Locally

1. **Make code changes** (e.g., modify CodeGenerator.cs)
2. **Build generator:**
   ```bash
   dotnet build ntoskrnlib.Generator -c Debug
   ```
3. **Test generation:**
   ```bash
   dotnet run --project ntoskrnlib.Generator -- \
     -m C:\Windows\System32\ntoskrnl.exe \
     -t _EPROCESS \
     --flatten \
     -o test-output
   ```
4. **Inspect output:**
   ```bash
   cat test-output/Win25H2/nt/_EPROCESS.g.cs
   ```
5. **Build library with new generated code:**
   ```bash
   dotnet build ntoskrnlib -c Debug
   ```
6. **Run samples:**
   ```bash
   dotnet run --project samples/StructureDemo
   ```

### Setting Up Symbol Path

**Windows Environment Variable:**
```powershell
# Use Microsoft symbol server + local cache
$env:_NT_SYMBOL_PATH = "srv*C:\Symbols*https://msdl.microsoft.com/download/symbols"

# Or in System Environment Variables:
# Variable: _NT_SYMBOL_PATH
# Value: srv*C:\Symbols*https://msdl.microsoft.com/download/symbols
```

**If not set:** Generator defaults to Microsoft symbol server with cache in `SymbolSession.cs:39-41`

---

## Code Generation Pipeline

### Detailed Flow

#### 1. Initialization (Program.cs)

```csharp
// Parse CLI arguments
var rootCommand = new RootCommand("Generate C# types from PDB symbols");
rootCommand.AddOption(moduleOption);
rootCommand.AddOption(typesOption);
// ... more options

// Setup DI container
var services = new ServiceCollection();
services.AddSingleton<ISymbolSessionFactory, SymbolSessionFactory>();
services.AddSingleton<ICodeGeneratorFactory, CodeGeneratorFactory>();
// ... more services

// Execute
rootCommand.SetHandler(async (options) => {
    var runner = serviceProvider.GetRequiredService<GenerationRunner>();
    await runner.RunAsync(options);
}, /* bind options */);
```

#### 2. Generation Orchestration (GenerationRunner.cs)

**Pseudo-code:**
```csharp
public async Task RunAsync(GenerationOptions options)
{
    // Load config file if provided
    if (options.ConfigPath != null)
    {
        var config = LoadYaml(options.ConfigPath);
        foreach (var moduleConfig in config.Types)
        {
            await GenerateForModule(moduleConfig);
        }
    }
    else
    {
        await GenerateForModule(options);
    }
}

private async Task GenerateForModule(ModuleConfig config)
{
    // Create symbol session
    var session = _sessionFactory.Create();
    session.LoadModule(config.ModulePath);

    // Try DbgHelp first
    try
    {
        var inspector = new TypeInspector(session);
        var generator = _generatorFactory.Create(inspector);
        var emitter = _emitterFactory.Create();

        // Generate types
        var typesToGenerate = config.All
            ? inspector.GetAllTypes()
            : config.Types;

        foreach (var typeName in typesToGenerate)
        {
            var code = generator.GenerateUdt(typeName, config);
            emitter.QueueForEmit(code);
        }

        emitter.EmitUdts(config.OutputPath);
    }
    catch (DbgHelpException)
    {
        // Fallback to DIA SDK
        var diaInspector = _diaFactory.Create(config.ModulePath);
        // ... DIA generation path
    }
}
```

#### 3. Type Lookup (TypeInspector.cs)

```csharp
public bool TryGetTypeIdByName(string typeName, out uint typeId)
{
    // Try with various module prefixes
    string[] prefixes = { "nt", "ntkrnlmp", "ntkrnlpa", "ntkrpamp" };

    foreach (var prefix in prefixes)
    {
        string fullName = $"{prefix}!{typeName}";
        if (DbgHelp.SymGetTypeFromName(_session.Handle, fullName, out var info))
        {
            typeId = info.TypeIndex;
            return true;
        }
    }

    typeId = 0;
    return false;
}
```

#### 4. Field Enumeration (TypeInspector.cs)

```csharp
public IEnumerable<FieldInfo> GetUdtFields(uint typeId)
{
    var fields = new List<FieldInfo>();

    // Enumerate children
    DbgHelp.SymEnumTypeFields(_session.Handle, typeId, (fieldSymbol) =>
    {
        var field = new FieldInfo
        {
            Name = fieldSymbol.Name,
            Offset = GetFieldOffset(fieldSymbol.TypeIndex),
            TypeId = fieldSymbol.TypeIndex,
            Size = GetTypeLength(fieldSymbol.TypeIndex)
        };
        fields.Add(field);
        return true; // Continue enumeration
    });

    return fields;
}
```

#### 5. Code Emission (CodeGenerator.cs)

```csharp
public string GenerateUdt(uint typeId, string typeName, GenerationOptions options)
{
    // Build Roslyn AST
    var compilationUnit = CompilationUnit()
        .AddUsings(
            UsingDirective(ParseName("System.Runtime.InteropServices"))
        )
        .AddMembers(
            NamespaceDeclaration(ParseName(DeriveNamespace(options)))
                .AddMembers(
                    StructDeclaration(typeName)
                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                        .AddAttributeLists(
                            AttributeList(SingletonSeparatedList(
                                Attribute(ParseName("StructLayout"))
                                    .AddArgumentListArguments(
                                        AttributeArgument(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                ParseName("LayoutKind"),
                                                IdentifierName("Explicit")
                                            )
                                        ),
                                        AttributeArgument(ParseExpression($"Size = 0x{size:X}"))
                                    )
                            ))
                        )
                        .AddMembers(GenerateFields(typeId, options.Flatten).ToArray())
                )
        );

    return compilationUnit.NormalizeWhitespace().ToFullString();
}
```

#### 6. Type Resolution (CodeGenerator.cs)

```csharp
private string ResolveType(uint fieldTypeId)
{
    var tag = _inspector.GetSymTag(fieldTypeId);

    switch (tag)
    {
        case SymTag.BaseType:
            return ResolveBaseType(fieldTypeId); // uint, ulong, etc.

        case SymTag.PointerType:
            return ResolvePointerType(fieldTypeId); // void*, _EPROCESS*, etc.

        case SymTag.UDT:
            return _inspector.GetTypeName(fieldTypeId); // _EPROCESS, _KTHREAD, etc.

        case SymTag.ArrayType:
            return ResolveArrayType(fieldTypeId); // byte[256], etc.

        default:
            return "byte"; // Fallback
    }
}
```

#### 7. File Writing (UdtEmitter.cs)

```csharp
public void EmitUdts(string outputPath)
{
    // BFS traversal for dependency ordering
    var queue = new Queue<UdtInfo>(_queuedTypes);
    var emitted = new HashSet<string>();

    while (queue.Count > 0)
    {
        var udt = queue.Dequeue();

        if (emitted.Contains(udt.Name))
            continue;

        // Ensure dependencies are emitted first (if not flattening)
        if (!options.Flatten)
        {
            foreach (var dep in udt.Dependencies)
            {
                if (!emitted.Contains(dep))
                    queue.Enqueue(FindUdt(dep));
            }
        }

        // Write regular struct
        var filePath = Path.Combine(outputPath, DeriveRelativePath(udt), $"{udt.Name}.g.cs");
        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        File.WriteAllText(filePath, udt.Code);

        // Write dynamic wrapper
        if (options.EmitDynamic)
        {
            var dynamicCode = _wrapperGenerator.Generate(udt);
            var dynamicPath = Path.Combine(outputPath, DeriveRelativePath(udt), "Dynamic", $"{udt.Name}.dynamic.g.cs");
            Directory.CreateDirectory(Path.GetDirectoryName(dynamicPath));
            File.WriteAllText(dynamicPath, dynamicCode);
        }

        emitted.Add(udt.Name);
    }
}
```

### MSBuild Integration

**In:** [ntoskrnlib/ntoskrnlib.csproj](ntoskrnlib/ntoskrnlib.csproj)

```xml
<Target Name="GenerateTypes" BeforeTargets="BeforeBuild" Condition="'$(OS)' == 'Windows_NT' AND '$(SkipGenerateTypes)' != 'true'">
    <Exec Command="dotnet run --project ../ntoskrnlib.Generator --configuration $(Configuration) -- --config ../config/types.yml --output Generated --winver Win25H2" />
</Target>

<ItemGroup>
    <Compile Include="Generated/**/*.g.cs" />
</ItemGroup>
```

This automatically runs the generator during `dotnet build` on Windows.

---

## Runtime Usage Patterns

### Basic Static Structure Usage

```csharp
using System.Runtime.InteropServices;
using ntoskrnlib.Generated.Win25H2.nt;

// Scenario 1: Marshal from pointer
IntPtr processPtr = GetProcessPointer(); // From kernel driver, etc.
_EPROCESS process = Marshal.PtrToStructure<_EPROCESS>(processPtr);
uint pid = process.UniqueProcessId;

// Scenario 2: Allocate and populate
_EPROCESS process = new _EPROCESS();
process.UniqueProcessId = 1234;

// Scenario 3: Fixed buffer
unsafe
{
    _EPROCESS* pProcess = (_EPROCESS*)processPtr;
    uint pid = pProcess->UniqueProcessId;
}
```

### Dynamic Structure Usage

```csharp
using ntoskrnlib.Structure;
using ntoskrnlib.Generated.Win25H2.nt.Dynamic;

// 1. Register dynamic types (once at startup)
DynamicStructure.RegisterTypes(typeof(Dynamic_EPROCESS).Assembly);

// 2. Create memory source
IMemorySource memorySource = new KernelMemorySource(); // Your implementation

// 3. Read dynamic structure
var service = new DynamicStructureService(memorySource);
MemoryPointer processAddr = new MemoryPointer(0x12345678);
Dynamic_EPROCESS process = service.Reads<Dynamic_EPROCESS>(processAddr);

// 4. Access fields dynamically
uint pid = process.ReadField<uint>("UniqueProcessId");
MemoryPointer threadListHead = process.ReadField<MemoryPointer>("ThreadListHead");

// 5. Safe reading with error handling
if (process.TryReadField<ulong>("SomeOptionalField", out var value))
{
    Console.WriteLine($"Value: {value}");
}
```

### Memory Pointer Arithmetic

```csharp
using ntoskrnlib.Structure;

// Basic construction
MemoryPointer ptr = new MemoryPointer(0x7FFE0000);
MemoryPointer ptr2 = new((ulong)someIntPtr);

// Arithmetic
MemoryPointer next = ptr + 0x10;          // Add offset
MemoryPointer prev = ptr - 8;             // Subtract offset
ptr++;                                     // Increment by 1
ptr += sizeof(ulong);                      // Increment by ulong size

// Pointer difference
long distance = next - ptr;                // Returns byte distance
long count = next.Difference(ptr);         // Same as above

// Comparisons
if (ptr < next) { /* ... */ }
if (ptr == MemoryPointer.Zero) { /* ... */ }
if (ptr.IsZero) { /* ... */ }

// Conversions
IntPtr intPtr = (IntPtr)ptr;
UIntPtr uintPtr = (UIntPtr)ptr;
ulong rawValue = ptr.Value;

// Display
Console.WriteLine(ptr); // Outputs: 0x7FFE0010
```

### Implementing IMemorySource

```csharp
using System;
using ntoskrnlib.Structure;

public class ProcessMemorySource : IMemorySource
{
    private readonly IntPtr _processHandle;

    public ProcessMemorySource(IntPtr processHandle)
    {
        _processHandle = processHandle;
    }

    public byte[] Read(MemoryPointer address, int length)
    {
        byte[] buffer = new byte[length];
        if (!ReadProcessMemory(_processHandle, (IntPtr)address, buffer, length, out _))
        {
            throw new InvalidOperationException($"Failed to read {length} bytes at {address}");
        }
        return buffer;
    }

    public void Write(MemoryPointer address, byte[] data)
    {
        if (!WriteProcessMemory(_processHandle, (IntPtr)address, data, data.Length, out _))
        {
            throw new InvalidOperationException($"Failed to write {data.Length} bytes at {address}");
        }
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
        byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
        byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);
}

// Usage
using var process = Process.GetProcessById(1234);
var memorySource = new ProcessMemorySource(process.Handle);
var service = new DynamicStructureService(memorySource);
var peb = service.Reads<Dynamic_PEB>(pebAddress);
```

### Zero-Reflection Registration

```csharp
using ntoskrnlib.Structure;

public class MyCustomStructure : DynamicStructure
{
    static MyCustomStructure()
    {
        // Explicit registration without reflection
        Register<MyCustomStructure>(
            baseAddress => new MyCustomStructure { BaseAddress = baseAddress },
            new Dictionary<string, ulong>
            {
                ["Field1"] = 0x00,
                ["Field2"] = 0x08,
                ["Field3"] = 0x10,
                ["NestedStruct"] = 0x20
            }
        );
    }
}

// No need to call RegisterTypes() - static constructor does it all
var service = new DynamicStructureService(memorySource);
var obj = service.Reads<MyCustomStructure>(address);
```

---

## Extension Points

### Adding New CLI Options

**1. Define option in Program.cs:**
```csharp
var myNewOption = new Option<string>(
    name: "--my-option",
    description: "Description of my new option",
    getDefaultValue: () => "default-value"
);
rootCommand.AddOption(myNewOption);
```

**2. Add to GenerationOptions.cs:**
```csharp
public class GenerationOptions
{
    // ... existing options
    public string MyOption { get; set; } = "default-value";
}
```

**3. Bind in SetHandler:**
```csharp
rootCommand.SetHandler(async (module, types, /* ... */, myNew) =>
{
    var options = new GenerationOptions
    {
        // ... existing bindings
        MyOption = myNew
    };
    await runner.RunAsync(options);
}, moduleOption, typesOption, /* ... */, myNewOption);
```

**4. Use in generator logic:**
```csharp
// In CodeGenerator.cs or wherever needed
if (options.MyOption == "special-mode")
{
    // Special handling
}
```

### Creating Custom Type Inspectors

**Implement interface in Gen/ folder:**
```csharp
public interface ITypeInspector
{
    bool TryGetTypeIdByName(string typeName, out uint typeId);
    IEnumerable<FieldInfo> GetUdtFields(uint typeId);
    uint GetTypeLength(uint typeId);
    string GetTypeName(uint typeId);
    // ... more methods
}

public class MyCustomInspector : ITypeInspector
{
    private readonly SomeSymbolEngine _engine;

    public MyCustomInspector(SomeSymbolEngine engine)
    {
        _engine = engine;
    }

    public bool TryGetTypeIdByName(string typeName, out uint typeId)
    {
        // Custom implementation using different symbol API
        return _engine.Lookup(typeName, out typeId);
    }

    // Implement other methods...
}
```

**Register in DI container:**
```csharp
// In Program.cs
services.AddSingleton<IMyCustomInspectorFactory, MyCustomInspectorFactory>();
```

**Use in GenerationRunner:**
```csharp
var inspector = _customInspectorFactory.Create();
var generator = _generatorFactory.Create(inspector);
```

### Implementing New Code Generators

**Create new generator class:**
```csharp
public class JsonSchemaGenerator
{
    private readonly ITypeInspector _inspector;

    public JsonSchemaGenerator(ITypeInspector inspector)
    {
        _inspector = inspector;
    }

    public string GenerateJsonSchema(uint typeId, string typeName)
    {
        var sb = new StringBuilder();
        sb.AppendLine("{");
        sb.AppendLine($"  \"type\": \"object\",");
        sb.AppendLine($"  \"title\": \"{typeName}\",");
        sb.AppendLine("  \"properties\": {");

        var fields = _inspector.GetUdtFields(typeId);
        foreach (var field in fields)
        {
            sb.AppendLine($"    \"{field.Name}\": {{");
            sb.AppendLine($"      \"type\": \"{DeriveJsonType(field.TypeId)}\"");
            sb.AppendLine("    },");
        }

        sb.AppendLine("  }");
        sb.AppendLine("}");
        return sb.ToString();
    }
}
```

**Integrate into pipeline:**
```csharp
// In GenerationRunner.cs
var jsonGenerator = new JsonSchemaGenerator(inspector);
var schema = jsonGenerator.GenerateJsonSchema(typeId, typeName);
File.WriteAllText($"{outputPath}/{typeName}.schema.json", schema);
```

### Adding New Runtime Features

**Example: Add change tracking to DynamicStructure:**

```csharp
public abstract class ChangeTrackingDynamicStructure : DynamicStructure
{
    private readonly Dictionary<string, object> _originalValues = new();
    private readonly HashSet<string> _changedFields = new();

    public bool IsFieldChanged(string fieldName)
    {
        return _changedFields.Contains(fieldName);
    }

    public void AcceptChanges()
    {
        _changedFields.Clear();
        _originalValues.Clear();
    }

    public new T ReadField<T>(string fieldName)
    {
        var value = base.ReadField<T>(fieldName);

        if (!_originalValues.ContainsKey(fieldName))
        {
            _originalValues[fieldName] = value;
        }
        else if (!EqualityComparer<T>.Default.Equals(value, (T)_originalValues[fieldName]))
        {
            _changedFields.Add(fieldName);
        }

        return value;
    }
}
```

**Usage:**
```csharp
public class MyTrackedStruct : ChangeTrackingDynamicStructure
{
    // Registration and field definitions
}

var obj = service.Reads<MyTrackedStruct>(address);
var value1 = obj.ReadField<int>("Counter");
System.Threading.Thread.Sleep(1000);
var value2 = obj.ReadField<int>("Counter");
if (obj.IsFieldChanged("Counter"))
{
    Console.WriteLine("Counter changed!");
}
```

---

## CI/CD Pipeline

### GitHub Actions Workflow

**File:** [.github/workflows/generate-types.yml](.github/workflows/generate-types.yml)

### Three-Job Pipeline

#### Job 1: Version Computation (Ubuntu)

**Purpose:** Determine semantic version for release

**Steps:**
1. Query NuGet API for latest published version
2. Parse git log for conventional commits since last version
3. Determine version bump:
   - `BREAKING CHANGE:` or `feat!:` → Major bump
   - `feat:` → Minor bump
   - `fix:`, `chore:`, etc. → Patch bump (if content changed)
4. Handle manual version override from workflow_dispatch
5. Output: `version` (e.g., `1.2.3`)

**Key Logic:**
```yaml
- name: Compute version
  run: |
    # Get latest from NuGet
    LATEST=$(curl -s 'https://api.nuget.org/v3-flatcontainer/ntoskrnlib/index.json' | jq -r '.versions[-1]')

    # Check for breaking changes
    if git log --format=%B | grep -q 'BREAKING CHANGE:\|feat!:'; then
      BUMP=major
    elif git log --format=%B | grep -q 'feat:'; then
      BUMP=minor
    else
      BUMP=patch
    fi

    # Compute new version
    NEW_VERSION=$(semver-bump $LATEST $BUMP)
    echo "version=$NEW_VERSION" >> $GITHUB_OUTPUT
```

#### Job 2: Build & Generate (Windows)

**Purpose:** Generate types, build, pack, and detect content changes

**Steps:**
1. Checkout code
2. Setup .NET 9.0
3. **Install/Register DIA SDK** (msdia140.dll) if missing
   - Downloads Visual Studio Build Tools installer
   - Extracts MSI packages
   - Registers COM DLL with regsvr32
4. Restore dependencies
5. **Build library** (triggers GenerateTypes MSBuild target)
6. Verify generated files exist
7. Pack NuGet package with base version from Job 1
8. **Compare SHA256 hash** of new assembly vs published version
9. If content changed but version didn't bump → increment patch version
10. Output: `version` (final), `changed` (true/false), `package-path`

**Key Logic:**
```yaml
- name: Check if content changed
  id: check-changed
  run: |
    # Download published package
    nuget install ntoskrnlib -Version ${{ needs.version.outputs.version }} -OutputDirectory old

    # Compute hashes
    OLD_HASH=$(sha256sum old/ntoskrnlib.*/lib/netstandard2.0/ntoskrnlib.dll | cut -d' ' -f1)
    NEW_HASH=$(sha256sum ntoskrnlib/bin/Release/netstandard2.0/ntoskrnlib.dll | cut -d' ' -f1)

    if [ "$OLD_HASH" != "$NEW_HASH" ]; then
      echo "changed=true" >> $GITHUB_OUTPUT
      # Bump patch if version wasn't already bumped
      FINAL_VERSION=$(increment-patch ${{ needs.version.outputs.version }})
      echo "version=$FINAL_VERSION" >> $GITHUB_OUTPUT
    else
      echo "changed=false" >> $GITHUB_OUTPUT
      echo "version=${{ needs.version.outputs.version }}" >> $GITHUB_OUTPUT
    fi
```

**DIA SDK Installation:**
```yaml
- name: Install and register DIA SDK if missing
  run: |
    if (!(Test-Path "C:\Windows\System32\msdia140.dll")) {
      Write-Host "msdia140.dll not found, installing Visual Studio Build Tools..."

      # Download installer
      Invoke-WebRequest -Uri "https://aka.ms/vs/17/release/vs_buildtools.exe" -OutFile vs_buildtools.exe

      # Install with DIA SDK component
      Start-Process -Wait -FilePath .\vs_buildtools.exe -ArgumentList "--quiet", "--wait", "--add", "Microsoft.VisualStudio.Component.VC.DiagnosticTools"

      # Register DIA
      regsvr32 /s "C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\DIA SDK\bin\amd64\msdia140.dll"
    } else {
      Write-Host "msdia140.dll already registered"
    }
```

#### Job 3: Publish (Ubuntu)

**Purpose:** Publish to NuGet and tag repository

**Conditions:**
- Runs only if `build.outputs.changed == 'true'`
- Requires `NUGET_API_KEY` secret

**Steps:**
1. Download build artifact (NuGet package)
2. Push package to nuget.org
3. Create git tag `v{version}`
4. Push tag to repository

**Key Logic:**
```yaml
- name: Publish to NuGet
  run: dotnet nuget push *.nupkg --api-key ${{ secrets.NUGET_API_KEY }} --source https://api.nuget.org/v3/index.json

- name: Create and push tag
  run: |
    git tag v${{ needs.build.outputs.version }}
    git push origin v${{ needs.build.outputs.version }}
```

### Automated PR Creation

**When:** Content changed (Generated/ files modified)

**Process:**
1. Create branch `update/generated-{timestamp}`
2. Commit changes: `git commit -m "chore(generated): update types for {winver}"`
3. Push branch
4. Create PR with auto-merge label
5. GitHub auto-merge (if enabled) merges PR automatically

**Benefits:**
- Generated code changes are tracked in git history
- Easy diffing between Windows versions
- Reviewable before merge (if auto-merge disabled)

### Triggers

**1. Push to master:**
```yaml
on:
  push:
    branches: [master]
    paths-ignore:
      - 'ntoskrnlib/Generated/**'
```

**2. Manual dispatch:**
```yaml
on:
  workflow_dispatch:
    inputs:
      version_override:
        description: 'Version override (e.g., 2.0.0)'
        required: false
```

**3. Scheduled (daily at 06:00 UTC):**
```yaml
on:
  schedule:
    - cron: '0 6 * * *'
```

### Semantic Versioning

**Conventional Commit Format:**
- `BREAKING CHANGE:` or `feat!:` → Major (1.x.x → 2.0.0)
- `feat:` → Minor (1.2.x → 1.3.0)
- `fix:`, `chore:`, `docs:` → Patch (1.2.3 → 1.2.4, if content changed)

**Examples:**
```
feat: add support for ARM64 structure generation
fix: correct field offset calculation for bitfields
chore(generated): update types for Win25H2
BREAKING CHANGE: remove deprecated DynamicArray.ReadAt() method
```

---

## Troubleshooting Guide

### Common Issues

#### 1. Symbol Path Not Set

**Symptom:**
```
Error: Failed to load symbols for C:\Windows\System32\ntoskrnl.exe
```

**Solution:**
Set `_NT_SYMBOL_PATH` environment variable:
```powershell
$env:_NT_SYMBOL_PATH = "srv*C:\Symbols*https://msdl.microsoft.com/download/symbols"
```

Or let the generator use its default (Microsoft symbol server).

**Check:** [Symbols/SymbolSession.cs:39-41](ntoskrnlib.Generator/Symbols/SymbolSession.cs#L39-L41)

#### 2. DIA SDK Not Registered

**Symptom:**
```
Error: Failed to create DIA data source (0x80040154 - Class not registered)
```

**Solution:**
Register msdia140.dll:
```powershell
# Find DIA SDK installation
$diaPath = "C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\DIA SDK\bin\amd64\msdia140.dll"

# Register as admin
regsvr32 /s $diaPath
```

**CI Solution:** See [.github/workflows/generate-types.yml:108-130](.github/workflows/generate-types.yml#L108-L130)

#### 3. Type Not Found

**Symptom:**
```
Error: Type '_EPROCESS' not found in module ntoskrnl.exe
```

**Possible Causes:**
1. Typo in type name (case-sensitive: `_EPROCESS` not `_eprocess`)
2. Type doesn't exist in this Windows version
3. Module name mismatch (try different prefixes)

**Solution:**
Check type exists using `symchk`:
```cmd
symchk /s C:\Windows\System32\ntoskrnl.exe
```

Or use WinDbg:
```
dt nt!_EPROCESS
```

**Code:** TypeInspector tries multiple prefixes automatically (see [TypeInspector.cs:80-115](ntoskrnlib.Generator/Gen/TypeInspector.cs#L80-L115))

#### 4. Build Fails with "GenerateTypes target failed"

**Symptom:**
```
error MSB3073: The command "dotnet run --project ../ntoskrnlib.Generator ..." exited with code 1
```

**Solution 1:** Check generator build:
```bash
dotnet build ntoskrnlib.Generator -c Release
```

**Solution 2:** Skip generation temporarily:
```bash
dotnet build ntoskrnlib -c Release /p:SkipGenerateTypes=true
```

**Solution 3:** Check generator logs for actual error (scroll up in build output)

#### 5. Generated Code Has Compilation Errors

**Symptom:**
```
error CS0246: The type or namespace name '_SOME_NESTED_TYPE' could not be found
```

**Cause:** Missing dependency (nested UDT not generated)

**Solution 1:** Use `--flatten` to inline nested types as byte arrays:
```bash
dotnet run --project ntoskrnlib.Generator -- -m <module> -t _TYPE --flatten
```

**Solution 2:** Remove `flatten: true` from config to generate dependencies:
```yaml
types:
  - module: C:\Windows\System32\ntoskrnl.exe
    types: [_EPROCESS]
    flatten: false  # Generate dependencies
```

#### 6. Memory Access Violations at Runtime

**Symptom:**
```
System.AccessViolationException: Attempted to read or write protected memory
```

**Cause:** Invalid memory address or incorrect structure layout

**Debug Steps:**
1. Verify address is valid in target process
2. Check structure size matches expected:
   ```csharp
   Console.WriteLine($"Size: {Marshal.SizeOf<_EPROCESS>():X}");
   ```
3. Compare with WinDbg: `dt nt!_EPROCESS`
4. Ensure reading from correct architecture (x64 vs x86)

**Solution:** Regenerate types for current Windows version:
```bash
dotnet run --project ntoskrnlib.Generator -- -c config/types.yml --winver Win11-25H2
```

#### 7. NuGet Package Push Fails

**Symptom:**
```
error: Response status code does not indicate success: 403 (Forbidden)
```

**Causes:**
1. Invalid API key
2. Version already exists
3. Package ID ownership issue

**Solution:**
```bash
# Check version doesn't exist
dotnet nuget search ntoskrnlib

# Generate new API key at https://www.nuget.org/account/apikeys

# Push with explicit source
dotnet nuget push ntoskrnlib.1.2.3.nupkg \
  --api-key <KEY> \
  --source https://api.nuget.org/v3/index.json
```

### Debug Tips

#### Enable Verbose Logging

**Generator:**
```bash
# Add logging configuration
export DOTNET_LOG_LEVEL=Debug
dotnet run --project ntoskrnlib.Generator -- <options>
```

**Or modify Program.cs:**
```csharp
services.AddLogging(builder =>
{
    builder.SetMinimumLevel(LogLevel.Debug);
    builder.AddConsole();
});
```

#### Inspect Generated Code

```bash
# Generate to separate directory for inspection
dotnet run --project ntoskrnlib.Generator -- \
  -m C:\Windows\System32\ntoskrnl.exe \
  -t _EPROCESS \
  -o temp-output

# View generated code
cat temp-output/Win25H2/nt/_EPROCESS.g.cs
cat temp-output/Win25H2/nt/Dynamic/_EPROCESS.dynamic.g.cs
```

#### Use WinDbg for Structure Validation

```cmd
# Start WinDbg
windbg -k

# Display structure
dt nt!_EPROCESS

# Display specific field
dt nt!_EPROCESS UniqueProcessId

# Display field offset
dt -v nt!_EPROCESS

# Compare with generated code
```

#### Attach Debugger to Generator

**Visual Studio:**
1. Open solution in Visual Studio
2. Set ntoskrnlib.Generator as startup project
3. Right-click → Properties → Debug → Application arguments: `--module C:\Windows\System32\ntoskrnl.exe --types _EPROCESS`
4. Set breakpoints in [CodeGenerator.cs](ntoskrnlib.Generator/Gen/CodeGenerator.cs) or [TypeInspector.cs](ntoskrnlib.Generator/Gen/TypeInspector.cs)
5. Press F5 to debug

**VS Code:**
```json
// .vscode/launch.json
{
    "name": "Debug Generator",
    "type": "coreclr",
    "request": "launch",
    "program": "ntoskrnlib.Generator/bin/Debug/net9.0/ntoskrnlib.Generator.dll",
    "args": [
        "--module", "C:\\Windows\\System32\\ntoskrnl.exe",
        "--types", "_EPROCESS",
        "--output", "test-output"
    ],
    "cwd": "${workspaceFolder}",
    "stopAtEntry": false
}
```

---

## References & Resources

### DbgHelp API Documentation

- **MSDN:** [DbgHelp Functions](https://docs.microsoft.com/en-us/windows/win32/debug/dbghelp-functions)
- **Key Functions:**
  - [SymInitialize](https://docs.microsoft.com/en-us/windows/win32/api/dbghelp/nf-dbghelp-syminitialize)
  - [SymLoadModuleEx](https://docs.microsoft.com/en-us/windows/win32/api/dbghelp/nf-dbghelp-symloadmoduleex)
  - [SymGetTypeFromName](https://docs.microsoft.com/en-us/windows/win32/api/dbghelp/nf-dbghelp-symgettypefromname)
  - [SymGetTypeInfo](https://docs.microsoft.com/en-us/windows/win32/api/dbghelp/nf-dbghelp-symgettypeinfo)

### DIA SDK Documentation

- **MSDN:** [Debug Interface Access SDK](https://docs.microsoft.com/en-us/visualstudio/debugger/debug-interface-access/debug-interface-access-sdk)
- **Interfaces:**
  - [IDiaDataSource](https://docs.microsoft.com/en-us/visualstudio/debugger/debug-interface-access/idiadatasource)
  - [IDiaSession](https://docs.microsoft.com/en-us/visualstudio/debugger/debug-interface-access/idiasession)
  - [IDiaSymbol](https://docs.microsoft.com/en-us/visualstudio/debugger/debug-interface-access/idiasymbol)

### Windows Internals Resources

- **Book:** *Windows Internals* (7th Edition) by Pavel Yosifovich, Mark Russinovich, et al.
- **WinDbg:** [Download Debugging Tools for Windows](https://docs.microsoft.com/en-us/windows-hardware/drivers/debugger/)
- **Symbol Server:** [Microsoft Symbol Server](https://docs.microsoft.com/en-us/windows-hardware/drivers/debugger/symbol-stores-and-symbol-servers)

### Roslyn Documentation

- **GitHub:** [dotnet/roslyn](https://github.com/dotnet/roslyn)
- **API Docs:** [Microsoft.CodeAnalysis](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis)
- **Syntax API:** [Roslyn Syntax API](https://docs.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-analysis)

### System.CommandLine

- **GitHub:** [dotnet/command-line-api](https://github.com/dotnet/command-line-api)
- **Docs:** [System.CommandLine Overview](https://docs.microsoft.com/en-us/dotnet/standard/commandline/)

### Semantic Versioning

- **Spec:** [semver.org](https://semver.org/)
- **Conventional Commits:** [conventionalcommits.org](https://www.conventionalcommits.org/)

### Related Projects

- **PInvoke.net:** [pinvoke.net](https://www.pinvoke.net/) - P/Invoke signatures database
- **ClrMD:** [microsoft/clrmd](https://github.com/microsoft/clrmd) - .NET memory dump analysis
- **WinDbgX:** [windbgx](https://apps.microsoft.com/store/detail/windbg-preview/9PGJGD53TN86) - Modern WinDbg

---

## Appendix: Quick Command Reference

### Generator CLI

```bash
# Single type, flattened
dotnet run --project ntoskrnlib.Generator -- -m C:\Windows\System32\ntoskrnl.exe -t _EPROCESS --flatten

# Multiple types
dotnet run --project ntoskrnlib.Generator -- -m C:\Windows\System32\ntdll.dll -t _PEB,_TEB

# All types from module
dotnet run --project ntoskrnlib.Generator -- -m C:\Windows\System32\ntoskrnl.exe --all

# Config-driven (recommended)
dotnet run --project ntoskrnlib.Generator -- -c config/types.yml -o ntoskrnlib/Generated --winver Win25H2

# Without dynamic wrappers
dotnet run --project ntoskrnlib.Generator -- -m <module> -t <type> --emit-dynamic false
```

### Build Commands

```bash
# Full build (with generation)
dotnet build -c Release

# Build without generation
dotnet build -c Release /p:SkipGenerateTypes=true

# Clean build
dotnet clean && dotnet build -c Release

# Pack NuGet
dotnet pack ntoskrnlib -c Release -o artifacts

# Run samples
dotnet run --project samples/StructureDemo
```

### Git Workflow

```bash
# Conventional commit examples
git commit -m "feat: add support for bitfield generation"
git commit -m "fix: correct field alignment in unions"
git commit -m "chore(generated): update types for Win11-25H2"
git commit -m "feat!: remove deprecated APIs" -m "BREAKING CHANGE: IMemorySource.ReadAt() removed"

# Tag version
git tag v1.2.3
git push origin v1.2.3
```

---

**Document Version:** 1.0
**Generated:** 2025-10-24
**For:** ntoskrnlib repository (master branch, commit f44c355)

**Feedback:** For issues or suggestions about this guide, create an issue at the repository or contribute via pull request.
