#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MMWORKING_SET_EXPANSION_HEAD
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListHead;
    }
}