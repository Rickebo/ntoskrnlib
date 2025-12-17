#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _CACHE_UNINITIALIZE_EVENT
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public _KEVENT Event;
    }
}