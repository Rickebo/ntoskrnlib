#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MMPTE_ACTIVE_PAGE_TABLE_LINKS
    {
        [FieldOffset(0)]
        public ulong Flink;
        [FieldOffset(0)]
        public ulong BlinkHigh;
    }
}