using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!POWER_ACTION_POLICY")]
    public sealed class POWER_ACTION_POLICY : DynamicStructure
    {
        public uint Action { get; }
        public uint Flags { get; }
        public uint EventCode { get; }

        public POWER_ACTION_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static POWER_ACTION_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(POWER_ACTION_POLICY.Action),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(POWER_ACTION_POLICY.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(POWER_ACTION_POLICY.EventCode),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<POWER_ACTION_POLICY>((mem, ptr) => new POWER_ACTION_POLICY(mem, ptr), offsets);
        }
    }
}