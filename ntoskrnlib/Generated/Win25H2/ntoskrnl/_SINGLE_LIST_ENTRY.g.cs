#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win25H2.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _SINGLE_LIST_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Next;
    }
}