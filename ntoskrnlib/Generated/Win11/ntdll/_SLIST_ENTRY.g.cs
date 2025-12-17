#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _SLIST_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Next;
    }
}