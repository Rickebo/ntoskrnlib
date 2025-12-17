using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSCHEDULING_GROUP_POLICY")]
    public sealed class _KSCHEDULING_GROUP_POLICY : DynamicStructure
    {
        public uint Value { get; }
        public ushort Weight { get; }
        public ushort MinRate { get; }
        public ushort MaxRate { get; }
        public uint AllFlags { get; }
        public uint Type { get; }
        public uint Disabled { get; }
        public uint RankBias { get; }
        public uint PerProcessorLimits { get; }
        public uint Spare1 { get; }

        public _KSCHEDULING_GROUP_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSCHEDULING_GROUP_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.Weight),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.MinRate),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.MaxRate),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.AllFlags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.Type),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.Disabled),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.RankBias),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.PerProcessorLimits),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KSCHEDULING_GROUP_POLICY.Spare1),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_KSCHEDULING_GROUP_POLICY>((mem, ptr) => new _KSCHEDULING_GROUP_POLICY(mem, ptr), offsets);
        }
    }
}