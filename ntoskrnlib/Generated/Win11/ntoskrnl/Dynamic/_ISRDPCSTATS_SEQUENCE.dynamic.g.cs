using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ISRDPCSTATS_SEQUENCE")]
    public sealed class _ISRDPCSTATS_SEQUENCE : DynamicStructure
    {
        public uint SequenceNumber { get; }
        public ulong IsrTime { get; }
        public ulong IsrCount { get; }
        public ulong DpcTime { get; }
        public ulong DpcCount { get; }

        public _ISRDPCSTATS_SEQUENCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ISRDPCSTATS_SEQUENCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ISRDPCSTATS_SEQUENCE.SequenceNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS_SEQUENCE.IsrTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS_SEQUENCE.IsrCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS_SEQUENCE.DpcTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS_SEQUENCE.DpcCount),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_ISRDPCSTATS_SEQUENCE>((mem, ptr) => new _ISRDPCSTATS_SEQUENCE(mem, ptr), offsets);
        }
    }
}