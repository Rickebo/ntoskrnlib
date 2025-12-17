#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _HEAP_LOCK
    {
        [FieldOffset(0)]
        public _unnamed_tag_ Lock;
    }
}