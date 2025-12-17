using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_CROSS_PARTITION_CHARGES")]
    public sealed class _MI_CROSS_PARTITION_CHARGES : DynamicStructure
    {
        public ulong CurrentCharges { get; }
        public ulong ChargeFailures { get; }
        public ulong ChargePeak { get; }
        public ulong MaximumAllowed { get; }

        public _MI_CROSS_PARTITION_CHARGES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_CROSS_PARTITION_CHARGES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_CROSS_PARTITION_CHARGES.CurrentCharges),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CROSS_PARTITION_CHARGES.ChargeFailures),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_CROSS_PARTITION_CHARGES.ChargePeak),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_CROSS_PARTITION_CHARGES.MaximumAllowed),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_CROSS_PARTITION_CHARGES>((mem, ptr) => new _MI_CROSS_PARTITION_CHARGES(mem, ptr), offsets);
        }
    }
}