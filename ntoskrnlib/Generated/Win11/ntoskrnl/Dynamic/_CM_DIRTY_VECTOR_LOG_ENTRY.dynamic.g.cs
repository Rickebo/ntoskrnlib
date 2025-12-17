using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_DIRTY_VECTOR_LOG_ENTRY")]
    public sealed class _CM_DIRTY_VECTOR_LOG_ENTRY : DynamicStructure
    {
        public IntPtr Thread { get; }
        public uint Operation { get; }
        public _unnamed_tag_ Data { get; }
        public byte[] Stack { get; }

        public _CM_DIRTY_VECTOR_LOG_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_DIRTY_VECTOR_LOG_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_DIRTY_VECTOR_LOG_ENTRY.Thread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_DIRTY_VECTOR_LOG_ENTRY.Operation),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_DIRTY_VECTOR_LOG_ENTRY.Data),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_CM_DIRTY_VECTOR_LOG_ENTRY.Stack),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_CM_DIRTY_VECTOR_LOG_ENTRY>((mem, ptr) => new _CM_DIRTY_VECTOR_LOG_ENTRY(mem, ptr), offsets);
        }
    }
}