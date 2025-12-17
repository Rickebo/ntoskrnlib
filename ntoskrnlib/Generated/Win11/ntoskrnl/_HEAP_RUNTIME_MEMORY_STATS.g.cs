#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _HEAP_RUNTIME_MEMORY_STATS
    {
        [FieldOffset(0)]
        public ulong TotalReservedPages;
        [FieldOffset(8)]
        public ulong TotalCommittedPages;
        [FieldOffset(16)]
        public ulong FreeCommittedPages;
        [FieldOffset(24)]
        public ulong LfhFreeCommittedPages;
        [FieldOffset(32)]
        public ulong VsFreeCommittedPages;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS[] LargePageStats;
        [FieldOffset(72)]
        public _RTL_HP_SEG_ALLOC_POLICY LargePageUtilizationPolicy;
    }
}