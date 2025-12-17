#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _HEAP_LOCK
    {
        [FieldOffset(0)]
        public _unnamed_tag_ Lock;
    }
}