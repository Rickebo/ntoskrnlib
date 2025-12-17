using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_LUID_TO_INDEX_MAP_ENTRY")]
    public sealed class _SEP_LUID_TO_INDEX_MAP_ENTRY : DynamicStructure
    {
        public _RTL_DYNAMIC_HASH_TABLE_ENTRY HashEntry { get; }
        public long ReferenceCount { get; }
        public ulong Luid { get; }
        public ulong IndexIntoGlobalSingletonTable { get; }
        public byte MarkedForDeletion { get; }

        public _SEP_LUID_TO_INDEX_MAP_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_LUID_TO_INDEX_MAP_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_LUID_TO_INDEX_MAP_ENTRY.HashEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_LUID_TO_INDEX_MAP_ENTRY.ReferenceCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEP_LUID_TO_INDEX_MAP_ENTRY.Luid),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEP_LUID_TO_INDEX_MAP_ENTRY.IndexIntoGlobalSingletonTable),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SEP_LUID_TO_INDEX_MAP_ENTRY.MarkedForDeletion),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_SEP_LUID_TO_INDEX_MAP_ENTRY>((mem, ptr) => new _SEP_LUID_TO_INDEX_MAP_ENTRY(mem, ptr), offsets);
        }
    }
}