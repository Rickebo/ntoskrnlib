using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGEFILE_METADATA_LAYOUT")]
    public sealed class _MI_PAGEFILE_METADATA_LAYOUT : DynamicStructure
    {
        public uint EntryInBytes { get; }
        public uint OwningPteOffset { get; }

        public _MI_PAGEFILE_METADATA_LAYOUT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGEFILE_METADATA_LAYOUT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGEFILE_METADATA_LAYOUT.EntryInBytes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGEFILE_METADATA_LAYOUT.OwningPteOffset),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_MI_PAGEFILE_METADATA_LAYOUT>((mem, ptr) => new _MI_PAGEFILE_METADATA_LAYOUT(mem, ptr), offsets);
        }
    }
}