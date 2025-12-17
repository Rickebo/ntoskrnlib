using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_RESTRICTED_MODWRITES")]
    public sealed class _MI_RESTRICTED_MODWRITES : DynamicStructure
    {
        public byte MaximumClusterPages { get; }
        public byte ReducedClusterWrites { get; }
        public byte ImposeDelay { get; }

        public _MI_RESTRICTED_MODWRITES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_RESTRICTED_MODWRITES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_RESTRICTED_MODWRITES.MaximumClusterPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_RESTRICTED_MODWRITES.ReducedClusterWrites),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MI_RESTRICTED_MODWRITES.ImposeDelay),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_MI_RESTRICTED_MODWRITES>((mem, ptr) => new _MI_RESTRICTED_MODWRITES(mem, ptr), offsets);
        }
    }
}