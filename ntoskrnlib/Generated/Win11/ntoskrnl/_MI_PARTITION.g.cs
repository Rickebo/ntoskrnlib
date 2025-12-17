#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 23872)]
    public partial struct _MI_PARTITION
    {
        [FieldOffset(0)]
        public _MI_PARTITION_CORE Core;
        [FieldOffset(480)]
        public _MI_PARTITION_MODWRITES Modwriter;
        [FieldOffset(1200)]
        public _MI_PARTITION_STORES Store;
        [FieldOffset(1728)]
        public _MI_PARTITION_SEGMENTS Segments;
        [FieldOffset(2880)]
        public _MI_PARTITION_PAGE_LISTS PageLists;
        [FieldOffset(16832)]
        public _MI_PARTITION_COMMIT Commit;
        [FieldOffset(16912)]
        public _MI_PARTITION_ZEROING Zeroing;
        [FieldOffset(16984)]
        public _MI_PAGE_COMBINING_SUPPORT PageCombine;
        [FieldOffset(17408)]
        public _MI_ACCESS_LOG_STATE AccessLog;
        [FieldOffset(17600)]
        public IntPtr WorkingSetControl;
        [FieldOffset(17608)]
        public _MMWORKING_SET_EXPANSION_HEAD WorkingSetExpansionHead;
        [FieldOffset(17624)]
        public _MI_SPECIAL_PURPOSE_MEMORY_STATE SpecialPurposeMemory;
        [FieldOffset(17728)]
        public _MI_PARTITION_SLABS Slabs;
        [FieldOffset(18432)]
        public ulong LastPeriodicTelemetryLogTime;
        [FieldOffset(18496)]
        public _MI_VISIBLE_PARTITION Vp;
    }
}