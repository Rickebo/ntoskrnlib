#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EXP_SECURE_POOL_CONTEXT
    {
        [FieldOffset(0)]
        public _EXP_POOL_CONTEXT_HEADER Header;
        [FieldOffset(8)]
        public IntPtr Handle;
    }
}