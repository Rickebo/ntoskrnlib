#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_ENTRY
    {
        [FieldOffset(0)]
        public _HEAP_UNPACKED_ENTRY UnpackedEntry;
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
        [FieldOffset(0)]
        public _HEAP_EXTENDED_ENTRY ExtendedEntry;
        [FieldOffset(0)]
        public IntPtr Reserved;
        [FieldOffset(8)]
        public ushort FunctionIndex;
        [FieldOffset(10)]
        public ushort ContextValue;
        [FieldOffset(8)]
        public uint InterceptorValue;
        [FieldOffset(12)]
        public ushort UnusedBytesLength;
        [FieldOffset(14)]
        public byte EntryOffset;
        [FieldOffset(15)]
        public byte ExtendedBlockSignature;
        [FieldOffset(0)]
        public IntPtr ReservedForAlignment;
        [FieldOffset(8)]
        public uint Code1;
        [FieldOffset(12)]
        public ushort Code2;
        [FieldOffset(14)]
        public byte Code3;
        [FieldOffset(15)]
        public byte Code4;
        [FieldOffset(12)]
        public uint Code234;
        [FieldOffset(8)]
        public ulong AgregateCode;
    }
}