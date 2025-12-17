using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_REMOVE_LOCK_COMMON_BLOCK")]
    public sealed class _IO_REMOVE_LOCK_COMMON_BLOCK : DynamicStructure
    {
        public byte Removed { get; }
        public byte[] Reserved { get; }
        public int IoCount { get; }
        public _KEVENT RemoveEvent { get; }

        public _IO_REMOVE_LOCK_COMMON_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_REMOVE_LOCK_COMMON_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_REMOVE_LOCK_COMMON_BLOCK.Removed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_REMOVE_LOCK_COMMON_BLOCK.Reserved),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_IO_REMOVE_LOCK_COMMON_BLOCK.IoCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IO_REMOVE_LOCK_COMMON_BLOCK.RemoveEvent),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IO_REMOVE_LOCK_COMMON_BLOCK>((mem, ptr) => new _IO_REMOVE_LOCK_COMMON_BLOCK(mem, ptr), offsets);
        }
    }
}