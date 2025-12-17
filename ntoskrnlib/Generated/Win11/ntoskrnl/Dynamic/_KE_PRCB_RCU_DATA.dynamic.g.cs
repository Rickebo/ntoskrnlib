using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KE_PRCB_RCU_DATA")]
    public sealed class _KE_PRCB_RCU_DATA : DynamicStructure
    {
        public uint NestingLevel { get; }
        public byte DispatchPin { get; }
        public byte GracePeriodNeeded { get; }
        public byte ExpediteReporting { get; }
        public sbyte IdleState { get; }
        public ulong GraceSequenceQuiescent { get; }
        public ulong GraceSequenceReported { get; }
        public IntPtr AwaitingCompletion { get; }

        public _KE_PRCB_RCU_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KE_PRCB_RCU_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KE_PRCB_RCU_DATA.NestingLevel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KE_PRCB_RCU_DATA.DispatchPin),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KE_PRCB_RCU_DATA.GracePeriodNeeded),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_KE_PRCB_RCU_DATA.ExpediteReporting),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_KE_PRCB_RCU_DATA.IdleState),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_KE_PRCB_RCU_DATA.GraceSequenceQuiescent),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KE_PRCB_RCU_DATA.GraceSequenceReported),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KE_PRCB_RCU_DATA.AwaitingCompletion),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_KE_PRCB_RCU_DATA>((mem, ptr) => new _KE_PRCB_RCU_DATA(mem, ptr), offsets);
        }
    }
}