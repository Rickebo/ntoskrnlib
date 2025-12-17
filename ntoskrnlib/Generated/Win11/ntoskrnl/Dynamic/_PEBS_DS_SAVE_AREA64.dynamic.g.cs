using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEBS_DS_SAVE_AREA64")]
    public sealed class _PEBS_DS_SAVE_AREA64 : DynamicStructure
    {
        public ulong BtsBufferBase { get; }
        public ulong BtsIndex { get; }
        public ulong BtsAbsoluteMaximum { get; }
        public ulong BtsInterruptThreshold { get; }
        public ulong PebsBufferBase { get; }
        public ulong PebsIndex { get; }
        public ulong PebsAbsoluteMaximum { get; }
        public ulong PebsInterruptThreshold { get; }
        public ulong[] PebsGpCounterReset { get; }
        public ulong[] PebsFixedCounterReset { get; }

        public _PEBS_DS_SAVE_AREA64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEBS_DS_SAVE_AREA64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEBS_DS_SAVE_AREA64.BtsBufferBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.BtsIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.BtsAbsoluteMaximum),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.BtsInterruptThreshold),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.PebsBufferBase),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.PebsIndex),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.PebsAbsoluteMaximum),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.PebsInterruptThreshold),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.PebsGpCounterReset),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA64.PebsFixedCounterReset),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_PEBS_DS_SAVE_AREA64>((mem, ptr) => new _PEBS_DS_SAVE_AREA64(mem, ptr), offsets);
        }
    }
}