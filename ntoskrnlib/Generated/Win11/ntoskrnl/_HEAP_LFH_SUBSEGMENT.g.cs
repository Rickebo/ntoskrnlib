#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _HEAP_LFH_SUBSEGMENT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public _HEAP_LFH_SUBSEGMENT_STATE State;
        [FieldOffset(24)]
        public _SINGLE_LIST_ENTRY OwnerFreeListEntry;
        [FieldOffset(24)]
        public byte CommitStateOffset;
        [FieldOffset(25)]
        public byte Spare0;
        [FieldOffset(32)]
        public ushort FreeCount;
        [FieldOffset(34)]
        public ushort BlockCount;
        [FieldOffset(36)]
        public byte FreeHint;
        [FieldOffset(37)]
        public byte WitheldBlockCount;
        [FieldOffset(38)]
        public byte CommitUnitShift;
        [FieldOffset(39)]
        public byte CommitUnitCount;
        [FieldOffset(38)]
        public _HEAP_LFH_COMMIT_UNIT_INFO CommitUnitInfo;
        [FieldOffset(40)]
        public _HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS BlockOffsets;
        [FieldOffset(44)]
        public ushort BucketRef;
        [FieldOffset(46)]
        public ushort PrivateSlotMapRef;
        [FieldOffset(48)]
        public ushort HighWatermarkBlockIndex;
        [FieldOffset(50)]
        public byte BitmapSearchWidth;
        [FieldOffset(51)]
        public byte PrivateFormat;
        [FieldOffset(51)]
        public byte Spare1;
        [FieldOffset(51)]
        public _HEAP_LFH_SUBSEGMENT_UCHAR_FIELDS UChar;
        [FieldOffset(52)]
        public uint Spare3;
        [FieldOffset(56)]
        public ulong CommitLock;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] BlockBitmap;
    }
}