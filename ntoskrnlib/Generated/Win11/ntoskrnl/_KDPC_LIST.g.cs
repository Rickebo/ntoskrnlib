#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KDPC_LIST
    {
        [FieldOffset(0)]
        public _SINGLE_LIST_ENTRY ListHead;
        [FieldOffset(8)]
        public IntPtr LastEntry;
    }
}