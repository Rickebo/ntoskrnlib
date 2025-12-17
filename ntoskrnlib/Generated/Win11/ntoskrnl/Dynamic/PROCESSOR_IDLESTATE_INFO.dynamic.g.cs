using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!PROCESSOR_IDLESTATE_INFO")]
    public sealed class PROCESSOR_IDLESTATE_INFO : DynamicStructure
    {
        public uint TimeCheck { get; }
        public byte DemotePercent { get; }
        public byte PromotePercent { get; }
        public byte[] Spare { get; }

        public PROCESSOR_IDLESTATE_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static PROCESSOR_IDLESTATE_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(PROCESSOR_IDLESTATE_INFO.TimeCheck),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(PROCESSOR_IDLESTATE_INFO.DemotePercent),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(PROCESSOR_IDLESTATE_INFO.PromotePercent),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(PROCESSOR_IDLESTATE_INFO.Spare),
                    new ulong[]
                    {
                        6UL
                    }
                }
            };
            Register<PROCESSOR_IDLESTATE_INFO>((mem, ptr) => new PROCESSOR_IDLESTATE_INFO(mem, ptr), offsets);
        }
    }
}