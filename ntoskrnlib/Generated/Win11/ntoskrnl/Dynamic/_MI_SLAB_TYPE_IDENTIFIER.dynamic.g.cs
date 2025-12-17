using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SLAB_TYPE_IDENTIFIER")]
    public sealed class _MI_SLAB_TYPE_IDENTIFIER : DynamicStructure
    {
        public byte SlabType { get; }
        public byte SlabIdentity { get; }
        public byte ChargesAcquired { get; }

        public _MI_SLAB_TYPE_IDENTIFIER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SLAB_TYPE_IDENTIFIER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SLAB_TYPE_IDENTIFIER.SlabType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SLAB_TYPE_IDENTIFIER.SlabIdentity),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MI_SLAB_TYPE_IDENTIFIER.ChargesAcquired),
                    new ulong[]
                    {
                        1UL
                    }
                }
            };
            Register<_MI_SLAB_TYPE_IDENTIFIER>((mem, ptr) => new _MI_SLAB_TYPE_IDENTIFIER(mem, ptr), offsets);
        }
    }
}