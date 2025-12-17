using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_STOP_ON_TAG")]
    public sealed class _HEAP_STOP_ON_TAG : DynamicStructure
    {
        public uint HeapAndTagIndex { get; }
        public ushort TagIndex { get; }
        public ushort HeapIndex { get; }

        public _HEAP_STOP_ON_TAG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_STOP_ON_TAG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_STOP_ON_TAG.HeapAndTagIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_STOP_ON_TAG.TagIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_STOP_ON_TAG.HeapIndex),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_HEAP_STOP_ON_TAG>((mem, ptr) => new _HEAP_STOP_ON_TAG(mem, ptr), offsets);
        }
    }
}