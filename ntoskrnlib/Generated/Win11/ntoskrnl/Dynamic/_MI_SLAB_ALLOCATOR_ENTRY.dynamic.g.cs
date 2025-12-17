using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SLAB_ALLOCATOR_ENTRY")]
    public sealed class _MI_SLAB_ALLOCATOR_ENTRY : DynamicStructure
    {
        public _MI_SLAB_ALLOCATOR_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SLAB_ALLOCATOR_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_MI_SLAB_ALLOCATOR_ENTRY>((mem, ptr) => new _MI_SLAB_ALLOCATOR_ENTRY(mem, ptr), offsets);
        }
    }
}