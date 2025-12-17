using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEBS_DS_SAVE_AREA32")]
    public sealed class _PEBS_DS_SAVE_AREA32 : DynamicStructure
    {
        public uint BtsBufferBase { get; }
        public uint BtsIndex { get; }
        public uint BtsAbsoluteMaximum { get; }
        public uint BtsInterruptThreshold { get; }
        public uint PebsBufferBase { get; }
        public uint PebsIndex { get; }
        public uint PebsAbsoluteMaximum { get; }
        public uint PebsInterruptThreshold { get; }
        public ulong[] PebsGpCounterReset { get; }
        public ulong[] PebsFixedCounterReset { get; }

        public _PEBS_DS_SAVE_AREA32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEBS_DS_SAVE_AREA32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEBS_DS_SAVE_AREA32.BtsBufferBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.BtsIndex),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.BtsAbsoluteMaximum),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.BtsInterruptThreshold),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.PebsBufferBase),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.PebsIndex),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.PebsAbsoluteMaximum),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.PebsInterruptThreshold),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.PebsGpCounterReset),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA32.PebsFixedCounterReset),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_PEBS_DS_SAVE_AREA32>((mem, ptr) => new _PEBS_DS_SAVE_AREA32(mem, ptr), offsets);
        }
    }
}