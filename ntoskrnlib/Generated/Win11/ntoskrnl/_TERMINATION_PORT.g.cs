#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _TERMINATION_PORT
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public IntPtr Port;
    }
}