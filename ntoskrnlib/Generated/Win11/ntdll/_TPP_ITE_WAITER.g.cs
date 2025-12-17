#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _TPP_ITE_WAITER
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public IntPtr ThreadId;
    }
}