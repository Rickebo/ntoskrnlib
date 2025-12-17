using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOCK_HEADER")]
    public sealed class _LOCK_HEADER : DynamicStructure
    {
        public _RTL_AVL_TREE LockTree { get; }
        public _RTL_AVL_TREE LockMdlSwitchedTree { get; }
        public ulong Count { get; }
        public int Lock { get; }
        public uint Valid { get; }

        public _LOCK_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOCK_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOCK_HEADER.LockTree),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOCK_HEADER.LockMdlSwitchedTree),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOCK_HEADER.Count),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOCK_HEADER.Lock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOCK_HEADER.Valid),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_LOCK_HEADER>((mem, ptr) => new _LOCK_HEADER(mem, ptr), offsets);
        }
    }
}