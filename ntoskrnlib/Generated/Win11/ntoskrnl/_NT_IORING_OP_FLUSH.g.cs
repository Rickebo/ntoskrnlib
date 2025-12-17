#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _NT_IORING_OP_FLUSH
    {
        [FieldOffset(0)]
        public uint CommonOpFlags;
        [FieldOffset(4)]
        public uint Flags;
        [FieldOffset(8)]
        public _NT_IORING_HANDLEREF File;
    }
}