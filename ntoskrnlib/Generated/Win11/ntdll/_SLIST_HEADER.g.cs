#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _SLIST_HEADER
    {
        [FieldOffset(0)]
        public ulong Alignment;
        [FieldOffset(8)]
        public ulong Region;
        [FieldOffset(0)]
        public _unnamed_tag_ HeaderX64;
    }
}