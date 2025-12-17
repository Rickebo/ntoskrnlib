#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_UNPACKED_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr PreviousBlockPrivateData;
        [FieldOffset(8)]
        public ushort Size;
        [FieldOffset(10)]
        public byte Flags;
        [FieldOffset(11)]
        public byte SmallTagIndex;
        [FieldOffset(8)]
        public uint SubSegmentCode;
        [FieldOffset(12)]
        public ushort PreviousSize;
        [FieldOffset(14)]
        public byte SegmentOffset;
        [FieldOffset(14)]
        public byte LFHFlags;
        [FieldOffset(15)]
        public byte UnusedBytes;
        [FieldOffset(8)]
        public ulong CompactHeader;
    }
}