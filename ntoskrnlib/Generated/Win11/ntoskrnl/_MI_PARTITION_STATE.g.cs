#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _MI_PARTITION_STATE
    {
        [FieldOffset(0)]
        public int PartitionLock;
        [FieldOffset(8)]
        public _EX_PUSH_LOCK PartitionIdLock;
        [FieldOffset(16)]
        public ulong InitialPartitionIdBits;
        [FieldOffset(24)]
        public _LIST_ENTRY PartitionList;
        [FieldOffset(40)]
        public IntPtr PartitionIdBitmap;
        [FieldOffset(48)]
        public _RTL_BITMAP InitialPartitionIdBitmap;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public IntPtr[] TempPartitionPointers;
        [FieldOffset(72)]
        public IntPtr Partition;
        [FieldOffset(80)]
        public uint CrossPartitionDenials;
        [FieldOffset(84)]
        public byte MultiplePartitionsExist;
        [FieldOffset(88)]
        public IntPtr ExtendedPartitionStart;
        [FieldOffset(96)]
        public ulong ExtendedPartitionBytes;
        [FieldOffset(104)]
        public ulong ChildPartitionBytes;
        [FieldOffset(112)]
        public _RTL_BITMAP_EX HugeIoPfnBitMap;
        [FieldOffset(128)]
        public IntPtr HugePfnDatabase;
        [FieldOffset(136)]
        public IntPtr HugePfnLockArray;
        [FieldOffset(192)]
        public int HugeRangesLock;
    }
}