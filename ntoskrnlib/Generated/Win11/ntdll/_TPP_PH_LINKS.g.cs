#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _TPP_PH_LINKS
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Siblings;
        [FieldOffset(16)]
        public _LIST_ENTRY Children;
        [FieldOffset(32)]
        public long Key;
    }
}