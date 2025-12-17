using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_PARTITION_CONTEXT")]
    public sealed class _ETW_PARTITION_CONTEXT : DynamicStructure
    {
        public IntPtr Partition { get; }

        public _ETW_PARTITION_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_PARTITION_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_PARTITION_CONTEXT.Partition),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ETW_PARTITION_CONTEXT>((mem, ptr) => new _ETW_PARTITION_CONTEXT(mem, ptr), offsets);
        }
    }
}