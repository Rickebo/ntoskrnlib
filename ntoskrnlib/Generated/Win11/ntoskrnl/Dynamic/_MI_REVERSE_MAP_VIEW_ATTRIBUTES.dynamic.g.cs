using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_REVERSE_MAP_VIEW_ATTRIBUTES")]
    public sealed class _MI_REVERSE_MAP_VIEW_ATTRIBUTES : DynamicStructure
    {
        public ulong FullSectionOffset { get; }
        public ulong NumberOfPtes { get; }
        public ulong PartitionId { get; }
        public ulong SectionOffset { get; }
        public ulong ViewState { get; }
        public ulong EntireField { get; }

        public _MI_REVERSE_MAP_VIEW_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_REVERSE_MAP_VIEW_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_REVERSE_MAP_VIEW_ATTRIBUTES.FullSectionOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REVERSE_MAP_VIEW_ATTRIBUTES.NumberOfPtes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REVERSE_MAP_VIEW_ATTRIBUTES.PartitionId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REVERSE_MAP_VIEW_ATTRIBUTES.SectionOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REVERSE_MAP_VIEW_ATTRIBUTES.ViewState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REVERSE_MAP_VIEW_ATTRIBUTES.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_REVERSE_MAP_VIEW_ATTRIBUTES>((mem, ptr) => new _MI_REVERSE_MAP_VIEW_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}