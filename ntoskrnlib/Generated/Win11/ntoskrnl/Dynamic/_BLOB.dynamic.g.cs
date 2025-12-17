using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BLOB")]
    public sealed class _BLOB : DynamicStructure
    {
        public _LIST_ENTRY ResourceList { get; }
        public _SLIST_ENTRY FreeListEntry { get; }
        public _unnamed_tag_ u1 { get; }
        public byte ResourceId { get; }
        public short CachedReferences { get; }
        public long ReferenceCount { get; }
        public _EX_PUSH_LOCK Lock { get; }

        public _BLOB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BLOB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BLOB.ResourceList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BLOB.FreeListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BLOB.u1),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_BLOB.ResourceId),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_BLOB.CachedReferences),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_BLOB.ReferenceCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_BLOB.Lock),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_BLOB>((mem, ptr) => new _BLOB(mem, ptr), offsets);
        }
    }
}