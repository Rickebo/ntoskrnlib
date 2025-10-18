using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=88)]
public struct _KLOCK_ENTRY
{
    [FieldOffset(0)]
    public _KLOCK_ENTRY_LOCK_STATE LockState;
    [FieldOffset(0)]
    public IntPtr LockUnsafe;
    [FieldOffset(0)]
    public byte CrossThreadReleasableAndBusyByte;
    [FieldOffset(1)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
    public byte[] Reserved;
    [FieldOffset(7)]
    public byte InTreeByte;
    [FieldOffset(8)]
    public uint EntryFlags;
    [FieldOffset(8)]
    public byte StaticByte;
    [FieldOffset(9)]
    public byte WaitingByte;
    [FieldOffset(10)]
    public byte AcquiredByte;
    [FieldOffset(11)]
    public byte CrossThreadFlags;
    [FieldOffset(12)]
    public uint SpareFlags;
    [FieldOffset(16)]
    public _RTL_BALANCED_NODE TreeNode;
    [FieldOffset(40)]
    public _RTL_RB_TREE OwnerTree;
    [FieldOffset(56)]
    public _RTL_RB_TREE WaiterTree;
    [FieldOffset(40)]
    public sbyte CpuPriorityKey;
    [FieldOffset(72)]
    public ulong EntryLock;
    [FieldOffset(80)]
    public _KLOCK_ENTRY_BOOST_BITMAP BoostBitmap;
}
