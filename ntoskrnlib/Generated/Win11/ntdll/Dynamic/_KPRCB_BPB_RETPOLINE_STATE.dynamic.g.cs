using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KPRCB_BPB_RETPOLINE_STATE")]
    public sealed class _KPRCB_BPB_RETPOLINE_STATE : DynamicStructure
    {
        public byte RunningNonRetpolineCode { get; }
        public byte IndirectCallsSafe { get; }
        public byte RetpolineEnabled { get; }
        public byte RetpolineStateReserved { get; }
        public byte AllFlags { get; }

        public _KPRCB_BPB_RETPOLINE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCB_BPB_RETPOLINE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRCB_BPB_RETPOLINE_STATE.RunningNonRetpolineCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_RETPOLINE_STATE.IndirectCallsSafe),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_RETPOLINE_STATE.RetpolineEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_RETPOLINE_STATE.RetpolineStateReserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_RETPOLINE_STATE.AllFlags),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KPRCB_BPB_RETPOLINE_STATE>((mem, ptr) => new _KPRCB_BPB_RETPOLINE_STATE(mem, ptr), offsets);
        }
    }
}