#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _NT_IORING_OP_READ_SCATTER
    {
        [FieldOffset(0)]
        public uint CommonOpFlags;
        [FieldOffset(4)]
        public uint Padding;
        [FieldOffset(8)]
        public _NT_IORING_HANDLEREF File;
        [FieldOffset(16)]
        public uint SegmentCount;
        [FieldOffset(24)]
        public IntPtr SegmentArray;
        [FieldOffset(32)]
        public ulong Offset;
        [FieldOffset(40)]
        public uint Length;
        [FieldOffset(44)]
        public uint Key;
    }
}