using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ISRDPCSTATS")]
    public sealed class _ISRDPCSTATS : DynamicStructure
    {
        public ulong IsrTime { get; }
        public ulong IsrTimeStart { get; }
        public ulong IsrCount { get; }
        public ulong DpcTime { get; }
        public ulong DpcTimeStart { get; }
        public ulong DpcCount { get; }
        public byte IsrActive { get; }
        public byte[] Reserved { get; }
        public _ISRDPCSTATS_SEQUENCE DpcWatchdog { get; }

        public _ISRDPCSTATS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ISRDPCSTATS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ISRDPCSTATS.IsrTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS.IsrTimeStart),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS.IsrCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS.DpcTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS.DpcTimeStart),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS.DpcCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS.IsrActive),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS.Reserved),
                    new ulong[]
                    {
                        49UL
                    }
                },
                {
                    nameof(_ISRDPCSTATS.DpcWatchdog),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_ISRDPCSTATS>((mem, ptr) => new _ISRDPCSTATS(mem, ptr), offsets);
        }
    }
}