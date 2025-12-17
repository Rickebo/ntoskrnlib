using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_DIRTY_VECTOR_LOG")]
    public sealed class _CM_DIRTY_VECTOR_LOG : DynamicStructure
    {
        public uint Next { get; }
        public uint Size { get; }
        public byte[] Log { get; }

        public _CM_DIRTY_VECTOR_LOG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_DIRTY_VECTOR_LOG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_DIRTY_VECTOR_LOG.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_DIRTY_VECTOR_LOG.Size),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_DIRTY_VECTOR_LOG.Log),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CM_DIRTY_VECTOR_LOG>((mem, ptr) => new _CM_DIRTY_VECTOR_LOG(mem, ptr), offsets);
        }
    }
}