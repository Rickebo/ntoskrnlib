#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _KEVENT
    {
        [FieldOffset(0)]
        public _DISPATCHER_HEADER Header;
    }
}