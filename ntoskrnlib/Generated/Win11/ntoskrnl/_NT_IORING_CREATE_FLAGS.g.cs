#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _NT_IORING_CREATE_FLAGS
    {
        [FieldOffset(0)]
        public uint Required;
        [FieldOffset(4)]
        public uint Advisory;
    }
}