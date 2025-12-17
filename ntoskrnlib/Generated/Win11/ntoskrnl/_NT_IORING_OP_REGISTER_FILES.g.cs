#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _NT_IORING_OP_REGISTER_FILES
    {
        [FieldOffset(0)]
        public uint CommonOpFlags;
        [FieldOffset(4)]
        public _NT_IORING_REG_FILES_FLAGS Flags;
        [FieldOffset(12)]
        public uint Count;
        [FieldOffset(16)]
        public IntPtr Handles;
    }
}