using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SLAB_IDENTITY_REFERENCE")]
    public sealed class _MI_SLAB_IDENTITY_REFERENCE : DynamicStructure
    {
        public long ReferenceCount { get; }

        public _MI_SLAB_IDENTITY_REFERENCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SLAB_IDENTITY_REFERENCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SLAB_IDENTITY_REFERENCE.ReferenceCount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_SLAB_IDENTITY_REFERENCE>((mem, ptr) => new _MI_SLAB_IDENTITY_REFERENCE(mem, ptr), offsets);
        }
    }
}