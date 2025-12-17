#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _CMP_DISCARD_AND_REPLACE_KCB_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr BaseKcb;
        [FieldOffset(8)]
        public int PrepareStatus;
        [FieldOffset(16)]
        public _LIST_ENTRY ClonedKcbListHead;
    }
}