using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROC_IDLE_STATE_BUCKET")]
    public sealed class _PROC_IDLE_STATE_BUCKET : DynamicStructure
    {
        public ulong TotalTime { get; }
        public ulong MinTime { get; }
        public ulong MaxTime { get; }
        public uint Count { get; }

        public _PROC_IDLE_STATE_BUCKET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_IDLE_STATE_BUCKET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_IDLE_STATE_BUCKET.TotalTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_BUCKET.MinTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_BUCKET.MaxTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_BUCKET.Count),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_PROC_IDLE_STATE_BUCKET>((mem, ptr) => new _PROC_IDLE_STATE_BUCKET(mem, ptr), offsets);
        }
    }
}