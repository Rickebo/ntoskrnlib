using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IMAGE_RUNTIME_FUNCTION_ENTRY")]
    public sealed class _IMAGE_RUNTIME_FUNCTION_ENTRY : DynamicStructure
    {
        public uint BeginAddress { get; }
        public uint EndAddress { get; }
        public uint UnwindInfoAddress { get; }
        public uint UnwindData { get; }

        public _IMAGE_RUNTIME_FUNCTION_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_RUNTIME_FUNCTION_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_RUNTIME_FUNCTION_ENTRY.BeginAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_RUNTIME_FUNCTION_ENTRY.EndAddress),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_RUNTIME_FUNCTION_ENTRY.UnwindInfoAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IMAGE_RUNTIME_FUNCTION_ENTRY.UnwindData),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IMAGE_RUNTIME_FUNCTION_ENTRY>((mem, ptr) => new _IMAGE_RUNTIME_FUNCTION_ENTRY(mem, ptr), offsets);
        }
    }
}