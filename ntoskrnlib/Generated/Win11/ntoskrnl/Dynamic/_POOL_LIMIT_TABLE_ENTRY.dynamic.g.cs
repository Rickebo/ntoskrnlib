using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POOL_LIMIT_TABLE_ENTRY")]
    public sealed class _POOL_LIMIT_TABLE_ENTRY : DynamicStructure
    {
        public _RTL_HASH_ENTRY HashEntry { get; }
        public ulong Reserved { get; }
        public _SINGLE_LIST_ENTRY SListEntry { get; }
        public byte[] LimitInfo { get; }
        public _WNF_STATE_NAME NotificationObject { get; }
        public _SLIST_ENTRY NotificationEntry { get; }
        public uint Scheduled { get; }

        public _POOL_LIMIT_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POOL_LIMIT_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POOL_LIMIT_TABLE_ENTRY.HashEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POOL_LIMIT_TABLE_ENTRY.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POOL_LIMIT_TABLE_ENTRY.SListEntry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POOL_LIMIT_TABLE_ENTRY.LimitInfo),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POOL_LIMIT_TABLE_ENTRY.NotificationObject),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POOL_LIMIT_TABLE_ENTRY.NotificationEntry),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POOL_LIMIT_TABLE_ENTRY.Scheduled),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_POOL_LIMIT_TABLE_ENTRY>((mem, ptr) => new _POOL_LIMIT_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}