#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _PAGED_LOOKASIDE_LIST
    {
        [FieldOffset(0)]
        public _GENERAL_LOOKASIDE L;
    }
}