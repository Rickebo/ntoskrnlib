#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS
    {
        [FieldOffset(0)]
        public ulong SmallPagesInUseWithinLarge;
        [FieldOffset(8)]
        public ulong OpportunisticLargePageCount;
    }
}