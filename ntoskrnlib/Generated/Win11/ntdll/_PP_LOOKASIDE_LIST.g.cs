#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PP_LOOKASIDE_LIST
    {
        [FieldOffset(0)]
        public IntPtr P;
        [FieldOffset(8)]
        public IntPtr L;
    }
}