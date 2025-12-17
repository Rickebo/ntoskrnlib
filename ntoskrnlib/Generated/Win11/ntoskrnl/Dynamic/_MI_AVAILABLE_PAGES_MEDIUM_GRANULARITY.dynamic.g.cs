using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY")]
    public sealed class _MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY : DynamicStructure
    {
        public ushort SmallFreeZeroPages { get; }
        public ushort SmallAvailablePages { get; }
        public ushort Spare { get; }
        public ushort EntireValue { get; }
        public short EntireValueSigned { get; }
        public short EntireValueVolatile { get; }

        public _MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY.SmallFreeZeroPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY.SmallAvailablePages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY.EntireValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY.EntireValueSigned),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY.EntireValueVolatile),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY>((mem, ptr) => new _MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY(mem, ptr), offsets);
        }
    }
}