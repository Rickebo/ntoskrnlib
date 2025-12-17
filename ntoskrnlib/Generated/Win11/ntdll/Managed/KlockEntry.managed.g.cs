using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KLOCK_ENTRY")]
    public sealed class KlockEntry : DynamicStructure
    {
        [Offset(0UL)]
        public KlockEntryLockState LockState { get => ReadStructure<KlockEntryLockState>(nameof(LockState)); set => WriteStructure(nameof(LockState), value); }

        [Offset(0UL)]
        public IntPtr LockUnsafe { get => ReadHere<IntPtr>(nameof(LockUnsafe)); set => WriteHere(nameof(LockUnsafe), value); }

        [Offset(0UL)]
        public byte CrossThreadReleasableAndBusyByte { get => ReadHere<byte>(nameof(CrossThreadReleasableAndBusyByte)); set => WriteHere(nameof(CrossThreadReleasableAndBusyByte), value); }

        [Offset(1UL)]
        [Length(6)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(7UL)]
        public byte InTreeByte { get => ReadHere<byte>(nameof(InTreeByte)); set => WriteHere(nameof(InTreeByte), value); }

        [Offset(8UL)]
        public uint EntryFlags { get => ReadHere<uint>(nameof(EntryFlags)); set => WriteHere(nameof(EntryFlags), value); }

        [Offset(8UL)]
        public byte StaticByte { get => ReadHere<byte>(nameof(StaticByte)); set => WriteHere(nameof(StaticByte), value); }

        [Offset(8UL)]
        public byte EntryIndex { get => ReadHere<byte>(nameof(EntryIndex)); set => WriteHere(nameof(EntryIndex), value); }

        [Offset(8UL)]
        public byte PreWaiting { get => ReadHere<byte>(nameof(PreWaiting)); set => WriteHere(nameof(PreWaiting), value); }

        [Offset(8UL)]
        public byte UserModeBit { get => ReadHere<byte>(nameof(UserModeBit)); set => WriteHere(nameof(UserModeBit), value); }

        [Offset(9UL)]
        public byte WaitingByte { get => ReadHere<byte>(nameof(WaitingByte)); set => WriteHere(nameof(WaitingByte), value); }

        [Offset(10UL)]
        public byte AcquiredByte { get => ReadHere<byte>(nameof(AcquiredByte)); set => WriteHere(nameof(AcquiredByte), value); }

        [Offset(11UL)]
        public byte CrossThreadFlags { get => ReadHere<byte>(nameof(CrossThreadFlags)); set => WriteHere(nameof(CrossThreadFlags), value); }

        [Offset(11UL)]
        public byte HeadNodeBit { get => ReadHere<byte>(nameof(HeadNodeBit)); set => WriteHere(nameof(HeadNodeBit), value); }

        [Offset(11UL)]
        public byte IoPriorityBit { get => ReadHere<byte>(nameof(IoPriorityBit)); set => WriteHere(nameof(IoPriorityBit), value); }

        [Offset(11UL)]
        public byte IoQoSWaiter { get => ReadHere<byte>(nameof(IoQoSWaiter)); set => WriteHere(nameof(IoQoSWaiter), value); }

        [Offset(11UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(8UL)]
        public uint StaticState { get => ReadHere<uint>(nameof(StaticState)); set => WriteHere(nameof(StaticState), value); }

        [Offset(8UL)]
        public uint AllFlags { get => ReadHere<uint>(nameof(AllFlags)); set => WriteHere(nameof(AllFlags), value); }

        [Offset(12UL)]
        public uint SpareFlags { get => ReadHere<uint>(nameof(SpareFlags)); set => WriteHere(nameof(SpareFlags), value); }

        [Offset(16UL)]
        public RtlBalancedNode TreeNode { get => ReadStructure<RtlBalancedNode>(nameof(TreeNode)); set => WriteStructure(nameof(TreeNode), value); }

        [Offset(40UL)]
        public RtlRbTree OwnerTree { get => ReadStructure<RtlRbTree>(nameof(OwnerTree)); set => WriteStructure(nameof(OwnerTree), value); }

        [Offset(56UL)]
        public RtlRbTree WaiterTree { get => ReadStructure<RtlRbTree>(nameof(WaiterTree)); set => WriteStructure(nameof(WaiterTree), value); }

        [Offset(40UL)]
        public sbyte CpuPriorityKey { get => ReadHere<sbyte>(nameof(CpuPriorityKey)); set => WriteHere(nameof(CpuPriorityKey), value); }

        [Offset(72UL)]
        public ulong EntryLock { get => ReadHere<ulong>(nameof(EntryLock)); set => WriteHere(nameof(EntryLock), value); }

        [Offset(80UL)]
        public KlockEntryBoostBitmap BoostBitmap { get => ReadStructure<KlockEntryBoostBitmap>(nameof(BoostBitmap)); set => WriteStructure(nameof(BoostBitmap), value); }

        public KlockEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KlockEntry>();
        }
    }
}