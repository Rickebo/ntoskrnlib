using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROC_IDLE_POLICY")]
    public sealed class _PROC_IDLE_POLICY : DynamicStructure
    {
        public byte PromotePercent { get; }
        public byte DemotePercent { get; }
        public byte PromotePercentBase { get; }
        public byte DemotePercentBase { get; }
        public byte AllowScaling { get; }
        public byte ForceLightIdle { get; }

        public _PROC_IDLE_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_IDLE_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_IDLE_POLICY.PromotePercent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_IDLE_POLICY.DemotePercent),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PROC_IDLE_POLICY.PromotePercentBase),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROC_IDLE_POLICY.DemotePercentBase),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PROC_IDLE_POLICY.AllowScaling),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROC_IDLE_POLICY.ForceLightIdle),
                    new ulong[]
                    {
                        5UL
                    }
                }
            };
            Register<_PROC_IDLE_POLICY>((mem, ptr) => new _PROC_IDLE_POLICY(mem, ptr), offsets);
        }
    }
}