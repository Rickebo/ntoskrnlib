#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _NT_IORING_OP_READ
    {
        [FieldOffset(0)]
        public uint CommonOpFlags;
        [FieldOffset(4)]
        public uint Padding;
        [FieldOffset(8)]
        public _NT_IORING_HANDLEREF File;
        [FieldOffset(16)]
        public _NT_IORING_BUFFERREF Buffer;
        [FieldOffset(24)]
        public ulong Offset;
        [FieldOffset(32)]
        public uint Length;
        [FieldOffset(36)]
        public uint Key;
    }
}