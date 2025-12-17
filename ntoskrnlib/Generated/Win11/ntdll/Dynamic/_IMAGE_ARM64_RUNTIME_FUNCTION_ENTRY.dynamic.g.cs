using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY")]
    public sealed class _IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY : DynamicStructure
    {
        public uint BeginAddress { get; }
        public uint UnwindData { get; }
        public uint Flag { get; }
        public uint FunctionLength { get; }
        public uint RegF { get; }
        public uint RegI { get; }
        public uint H { get; }
        public uint CR { get; }
        public uint FrameSize { get; }

        public _IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.BeginAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.UnwindData),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.Flag),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.FunctionLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.RegF),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.RegI),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.H),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.CR),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY.FrameSize),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY>((mem, ptr) => new _IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY(mem, ptr), offsets);
        }
    }
}