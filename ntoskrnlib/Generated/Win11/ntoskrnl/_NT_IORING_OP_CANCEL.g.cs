#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _NT_IORING_OP_CANCEL
    {
        [FieldOffset(0)]
        public uint CommonOpFlags;
        [FieldOffset(8)]
        public _NT_IORING_HANDLEREF File;
        [FieldOffset(16)]
        public ulong CancelId;
    }
}