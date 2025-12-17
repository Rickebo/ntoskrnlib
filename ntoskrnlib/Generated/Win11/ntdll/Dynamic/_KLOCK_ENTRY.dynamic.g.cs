using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KLOCK_ENTRY")]
    public sealed class _KLOCK_ENTRY : DynamicStructure
    {
        public _KLOCK_ENTRY_LOCK_STATE LockState { get; }
        public IntPtr LockUnsafe { get; }
        public byte CrossThreadReleasableAndBusyByte { get; }
        public byte[] Reserved { get; }
        public byte InTreeByte { get; }
        public uint EntryFlags { get; }
        public byte StaticByte { get; }
        public byte EntryIndex { get; }
        public byte PreWaiting { get; }
        public byte UserModeBit { get; }
        public byte WaitingByte { get; }
        public byte AcquiredByte { get; }
        public byte CrossThreadFlags { get; }
        public byte HeadNodeBit { get; }
        public byte IoPriorityBit { get; }
        public byte IoQoSWaiter { get; }
        public byte Spare1 { get; }
        public uint StaticState { get; }
        public uint AllFlags { get; }
        public uint SpareFlags { get; }
        public _RTL_BALANCED_NODE TreeNode { get; }
        public _RTL_RB_TREE OwnerTree { get; }
        public _RTL_RB_TREE WaiterTree { get; }
        public sbyte CpuPriorityKey { get; }
        public ulong EntryLock { get; }
        public _KLOCK_ENTRY_BOOST_BITMAP BoostBitmap { get; }

        public _KLOCK_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KLOCK_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KLOCK_ENTRY.LockState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.LockUnsafe),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.CrossThreadReleasableAndBusyByte),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.Reserved),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.InTreeByte),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.EntryFlags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.StaticByte),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.EntryIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.PreWaiting),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.UserModeBit),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.WaitingByte),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.AcquiredByte),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.CrossThreadFlags),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.HeadNodeBit),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.IoPriorityBit),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.IoQoSWaiter),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.Spare1),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.StaticState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.AllFlags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.SpareFlags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.TreeNode),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.OwnerTree),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.WaiterTree),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.CpuPriorityKey),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.EntryLock),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY.BoostBitmap),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_KLOCK_ENTRY>((mem, ptr) => new _KLOCK_ENTRY(mem, ptr), offsets);
        }
    }
}