#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_VS_DELAY_FREE_CONTEXT
    {
        [FieldOffset(0)]
        public _SLIST_HEADER ListHead;
    }
}