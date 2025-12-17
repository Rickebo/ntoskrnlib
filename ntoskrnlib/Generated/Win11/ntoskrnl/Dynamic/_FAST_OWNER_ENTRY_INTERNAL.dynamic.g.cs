using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAST_OWNER_ENTRY_INTERNAL")]
    public sealed class _FAST_OWNER_ENTRY_INTERNAL : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr ThreadAddressAndDisowned { get; }
        public IntPtr LockAddress { get; }
        public int RecursiveReferenceCount { get; }
        public byte AbLockHandle { get; }
        public byte DynamicallyAllocated { get; }
        public byte CallerExclusive { get; }
        public byte CurrentlyWaitingShared { get; }
        public byte[] Reserved { get; }

        public _FAST_OWNER_ENTRY_INTERNAL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAST_OWNER_ENTRY_INTERNAL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.ThreadAddressAndDisowned),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.LockAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.RecursiveReferenceCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.AbLockHandle),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.DynamicallyAllocated),
                    new ulong[]
                    {
                        37UL
                    }
                },
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.CallerExclusive),
                    new ulong[]
                    {
                        37UL
                    }
                },
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.CurrentlyWaitingShared),
                    new ulong[]
                    {
                        37UL
                    }
                },
                {
                    nameof(_FAST_OWNER_ENTRY_INTERNAL.Reserved),
                    new ulong[]
                    {
                        38UL
                    }
                }
            };
            Register<_FAST_OWNER_ENTRY_INTERNAL>((mem, ptr) => new _FAST_OWNER_ENTRY_INTERNAL(mem, ptr), offsets);
        }
    }
}