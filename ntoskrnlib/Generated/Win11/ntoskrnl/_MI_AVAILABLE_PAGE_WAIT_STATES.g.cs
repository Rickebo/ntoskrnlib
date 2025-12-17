#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_AVAILABLE_PAGE_WAIT_STATES
    {
        [FieldOffset(0)]
        public _KEVENT Event;
        [FieldOffset(24)]
        public uint EventSets;
    }
}