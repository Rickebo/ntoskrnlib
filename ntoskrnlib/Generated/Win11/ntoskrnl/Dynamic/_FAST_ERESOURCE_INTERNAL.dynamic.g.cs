using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAST_ERESOURCE_INTERNAL")]
    public sealed class _FAST_ERESOURCE_INTERNAL : DynamicStructure
    {
        public FAST_ERESOURCE_LOCK_STATE LockWord { get; }
        public _KWAIT_CHAIN SharedWaiters { get; }
        public _KWAIT_CHAIN ExclusiveWaiters { get; }
        public byte Reserved { get; }
        public sbyte MiscFlags { get; }
        public ushort Flag { get; }
        public uint ResourceTimeoutCount { get; }
        public uint Reserved1 { get; }
        public ulong CreatorBackTraceIndex { get; }
        public ulong SpinLock { get; }
        public uint NumberOfSharedWaiters { get; }
        public uint ContentionCount { get; }
        public _FAST_OWNER_ENTRY_INTERNAL ExclusiveOwnerEntry { get; }

        public _FAST_ERESOURCE_INTERNAL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAST_ERESOURCE_INTERNAL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.LockWord),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.SharedWaiters),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.ExclusiveWaiters),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.Reserved),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.MiscFlags),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.Flag),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.ResourceTimeoutCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.Reserved1),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.CreatorBackTraceIndex),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.SpinLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.NumberOfSharedWaiters),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.ContentionCount),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_FAST_ERESOURCE_INTERNAL.ExclusiveOwnerEntry),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_FAST_ERESOURCE_INTERNAL>((mem, ptr) => new _FAST_ERESOURCE_INTERNAL(mem, ptr), offsets);
        }
    }
}