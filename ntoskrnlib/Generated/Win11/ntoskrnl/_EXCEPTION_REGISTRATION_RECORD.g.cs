#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EXCEPTION_REGISTRATION_RECORD
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public IntPtr Handler;
    }
}