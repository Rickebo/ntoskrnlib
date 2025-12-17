using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPRCB_BPB_STATE")]
    public sealed class _KPRCB_BPB_STATE : DynamicStructure
    {
        public ushort CpuIdle { get; }
        public ushort FlushRsbOnTrap { get; }
        public ushort IbpbOnReturn { get; }
        public ushort IbpbOnTrap { get; }
        public ushort IbpbOnRetpolineExit { get; }
        public ushort FlushRsbOnReturn { get; }
        public ushort FlushRsbOnRetpolineExit { get; }
        public ushort FlushBhbOnTrap { get; }
        public ushort DivideOnReturn { get; }
        public ushort VerwOnNonKvaReturn { get; }
        public ushort Spare { get; }
        public ushort AllFlags { get; }

        public _KPRCB_BPB_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCB_BPB_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRCB_BPB_STATE.CpuIdle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.FlushRsbOnTrap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.IbpbOnReturn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.IbpbOnTrap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.IbpbOnRetpolineExit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.FlushRsbOnReturn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.FlushRsbOnRetpolineExit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.FlushBhbOnTrap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.DivideOnReturn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.VerwOnNonKvaReturn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB_BPB_STATE.AllFlags),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KPRCB_BPB_STATE>((mem, ptr) => new _KPRCB_BPB_STATE(mem, ptr), offsets);
        }
    }
}