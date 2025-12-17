#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _EX_RUNDOWN_REF
    {
        [FieldOffset(0)]
        public ulong Count;
        [FieldOffset(0)]
        public IntPtr Ptr;
    }
}