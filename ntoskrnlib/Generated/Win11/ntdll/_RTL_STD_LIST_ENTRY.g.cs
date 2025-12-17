#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _RTL_STD_LIST_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Next;
    }
}