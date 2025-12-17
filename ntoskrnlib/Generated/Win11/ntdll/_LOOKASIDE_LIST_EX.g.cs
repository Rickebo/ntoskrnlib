#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _LOOKASIDE_LIST_EX
    {
        [FieldOffset(0)]
        public _GENERAL_LOOKASIDE_POOL L;
    }
}