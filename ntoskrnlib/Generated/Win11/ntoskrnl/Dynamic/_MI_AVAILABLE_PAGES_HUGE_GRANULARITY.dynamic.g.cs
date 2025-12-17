using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_AVAILABLE_PAGES_HUGE_GRANULARITY")]
    public sealed class _MI_AVAILABLE_PAGES_HUGE_GRANULARITY : DynamicStructure
    {
        public uint SmallAvailablePages { get; }
        public uint LargeFreeZeroPages { get; }
        public uint Spare { get; }
        public uint EntireValue { get; }
        public int EntireValueSigned { get; }
        public int EntireValueVolatile { get; }

        public _MI_AVAILABLE_PAGES_HUGE_GRANULARITY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_AVAILABLE_PAGES_HUGE_GRANULARITY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_AVAILABLE_PAGES_HUGE_GRANULARITY.SmallAvailablePages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_HUGE_GRANULARITY.LargeFreeZeroPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_HUGE_GRANULARITY.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_HUGE_GRANULARITY.EntireValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_HUGE_GRANULARITY.EntireValueSigned),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_HUGE_GRANULARITY.EntireValueVolatile),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_AVAILABLE_PAGES_HUGE_GRANULARITY>((mem, ptr) => new _MI_AVAILABLE_PAGES_HUGE_GRANULARITY(mem, ptr), offsets);
        }
    }
}