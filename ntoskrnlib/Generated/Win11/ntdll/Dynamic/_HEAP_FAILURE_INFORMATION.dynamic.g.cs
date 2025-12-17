using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_FAILURE_INFORMATION")]
    public sealed class _HEAP_FAILURE_INFORMATION : DynamicStructure
    {
        public uint Version { get; }
        public uint StructureSize { get; }
        public uint FailureType { get; }
        public IntPtr HeapAddress { get; }
        public IntPtr Address { get; }
        public IntPtr Param1 { get; }
        public IntPtr Param2 { get; }
        public IntPtr Param3 { get; }
        public IntPtr PreviousBlock { get; }
        public IntPtr NextBlock { get; }
        public _FAKE_HEAP_ENTRY ExpectedDecodedEntry { get; }
        public byte[] StackTrace { get; }
        public byte HeapMajorVersion { get; }
        public byte HeapMinorVersion { get; }
        public _EXCEPTION_RECORD ExceptionRecord { get; }
        public _CONTEXT ContextRecord { get; }

        public _HEAP_FAILURE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_FAILURE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_FAILURE_INFORMATION.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.StructureSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.FailureType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.HeapAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.Address),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.Param1),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.Param2),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.Param3),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.PreviousBlock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.NextBlock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.ExpectedDecodedEntry),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.StackTrace),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.HeapMajorVersion),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.HeapMinorVersion),
                    new ulong[]
                    {
                        345UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.ExceptionRecord),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_HEAP_FAILURE_INFORMATION.ContextRecord),
                    new ulong[]
                    {
                        512UL
                    }
                }
            };
            Register<_HEAP_FAILURE_INFORMATION>((mem, ptr) => new _HEAP_FAILURE_INFORMATION(mem, ptr), offsets);
        }
    }
}