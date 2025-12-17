using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!PROCESSOR_PERFSTATE_POLICY")]
    public sealed class PROCESSOR_PERFSTATE_POLICY : DynamicStructure
    {
        public uint Revision { get; }
        public byte MaxThrottle { get; }
        public byte MinThrottle { get; }
        public byte BusyAdjThreshold { get; }
        public byte Spare { get; }
        public _unnamed_tag_ Flags { get; }
        public uint TimeCheck { get; }
        public uint IncreaseTime { get; }
        public uint DecreaseTime { get; }
        public uint IncreasePercent { get; }
        public uint DecreasePercent { get; }

        public PROCESSOR_PERFSTATE_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static PROCESSOR_PERFSTATE_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.Revision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.MaxThrottle),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.MinThrottle),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.BusyAdjThreshold),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.Spare),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.Flags),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.TimeCheck),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.IncreaseTime),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.DecreaseTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.IncreasePercent),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(PROCESSOR_PERFSTATE_POLICY.DecreasePercent),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<PROCESSOR_PERFSTATE_POLICY>((mem, ptr) => new PROCESSOR_PERFSTATE_POLICY(mem, ptr), offsets);
        }
    }
}