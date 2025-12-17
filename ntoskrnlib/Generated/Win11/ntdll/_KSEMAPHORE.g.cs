#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _KSEMAPHORE
    {
        [FieldOffset(0)]
        public _DISPATCHER_HEADER Header;
        [FieldOffset(24)]
        public int Limit;
    }
}