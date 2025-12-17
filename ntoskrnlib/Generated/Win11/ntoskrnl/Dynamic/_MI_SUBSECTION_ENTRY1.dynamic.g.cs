using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SUBSECTION_ENTRY1")]
    public sealed class _MI_SUBSECTION_ENTRY1 : DynamicStructure
    {
        public uint CrossPartitionReferences { get; }
        public uint SubsectionMappedLarge { get; }

        public _MI_SUBSECTION_ENTRY1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SUBSECTION_ENTRY1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SUBSECTION_ENTRY1.CrossPartitionReferences),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SUBSECTION_ENTRY1.SubsectionMappedLarge),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_SUBSECTION_ENTRY1>((mem, ptr) => new _MI_SUBSECTION_ENTRY1(mem, ptr), offsets);
        }
    }
}