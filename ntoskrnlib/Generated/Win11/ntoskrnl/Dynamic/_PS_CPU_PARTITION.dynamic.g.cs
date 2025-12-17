using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PS_CPU_PARTITION")]
    public sealed class _PS_CPU_PARTITION : DynamicStructure
    {
        public IntPtr Partition { get; }
        public IntPtr Parent { get; }
        public _LIST_ENTRY PartitionListEntry { get; }

        public _PS_CPU_PARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_CPU_PARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_CPU_PARTITION.Partition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_CPU_PARTITION.Parent),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PS_CPU_PARTITION.PartitionListEntry),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PS_CPU_PARTITION>((mem, ptr) => new _PS_CPU_PARTITION(mem, ptr), offsets);
        }
    }
}