using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!SYSTEM_POWER_LEVEL")]
    public sealed class SYSTEM_POWER_LEVEL : DynamicStructure
    {
        public byte Enable { get; }
        public byte[] Spare { get; }
        public uint BatteryLevel { get; }
        public POWER_ACTION_POLICY PowerPolicy { get; }
        public uint MinSystemState { get; }

        public SYSTEM_POWER_LEVEL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static SYSTEM_POWER_LEVEL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(SYSTEM_POWER_LEVEL.Enable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_LEVEL.Spare),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_LEVEL.BatteryLevel),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_LEVEL.PowerPolicy),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(SYSTEM_POWER_LEVEL.MinSystemState),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<SYSTEM_POWER_LEVEL>((mem, ptr) => new SYSTEM_POWER_LEVEL(mem, ptr), offsets);
        }
    }
}