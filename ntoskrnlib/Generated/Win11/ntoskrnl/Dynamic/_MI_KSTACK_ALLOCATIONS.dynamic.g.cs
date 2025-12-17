using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_KSTACK_ALLOCATIONS")]
    public sealed class _MI_KSTACK_ALLOCATIONS : DynamicStructure
    {
        public uint[] AllocationPeaks { get; }

        public _MI_KSTACK_ALLOCATIONS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_KSTACK_ALLOCATIONS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_KSTACK_ALLOCATIONS.AllocationPeaks),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_KSTACK_ALLOCATIONS>((mem, ptr) => new _MI_KSTACK_ALLOCATIONS(mem, ptr), offsets);
        }
    }
}