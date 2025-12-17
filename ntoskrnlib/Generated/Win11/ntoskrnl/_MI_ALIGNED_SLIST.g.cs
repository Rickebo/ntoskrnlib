#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_ALIGNED_SLIST
    {
        [FieldOffset(0)]
        public _SLIST_HEADER SList;
    }
}