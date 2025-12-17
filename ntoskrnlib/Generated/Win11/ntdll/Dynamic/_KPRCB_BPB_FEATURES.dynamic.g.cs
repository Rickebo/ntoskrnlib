using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KPRCB_BPB_FEATURES")]
    public sealed class _KPRCB_BPB_FEATURES : DynamicStructure
    {
        public byte ClearOnIdle { get; }
        public byte Enabled { get; }
        public byte Smep { get; }
        public byte KCet { get; }
        public byte BhbFlushSequence { get; }
        public byte FeaturesReserved2 { get; }
        public byte FeaturesReserved { get; }
        public byte AllFlags { get; }

        public _KPRCB_BPB_FEATURES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCB_BPB_FEATURES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRCB_BPB_FEATURES.ClearOnIdle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_FEATURES.Enabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_FEATURES.Smep),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_FEATURES.KCet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_FEATURES.BhbFlushSequence),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_FEATURES.FeaturesReserved2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_FEATURES.FeaturesReserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_FEATURES.AllFlags),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KPRCB_BPB_FEATURES>((mem, ptr) => new _KPRCB_BPB_FEATURES(mem, ptr), offsets);
        }
    }
}