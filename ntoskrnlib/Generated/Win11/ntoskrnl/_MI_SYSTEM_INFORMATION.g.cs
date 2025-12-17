#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 49600)]
    public partial struct _MI_SYSTEM_INFORMATION
    {
        [FieldOffset(0)]
        public _MI_POOL_STATE Pools;
        [FieldOffset(448)]
        public _MI_SECTION_STATE Sections;
        [FieldOffset(3520)]
        public _MI_SYSTEM_IMAGE_STATE SystemImages;
        [FieldOffset(4096)]
        public _MI_PROCESS_STATE Processes;
        [FieldOffset(4224)]
        public _MI_HARDWARE_STATE Hardware;
        [FieldOffset(9088)]
        public _MI_SYSTEM_VA_STATE SystemVa;
        [FieldOffset(13248)]
        public _MI_COMBINE_STATE PageCombines;
        [FieldOffset(13280)]
        public _MI_PAGELIST_STATE PageLists;
        [FieldOffset(13568)]
        public _MI_PARTITION_STATE Partitions;
        [FieldOffset(13824)]
        public _MI_SHUTDOWN_STATE Shutdowns;
        [FieldOffset(13952)]
        public _MI_ERROR_STATE Errors;
        [FieldOffset(14208)]
        public _MI_DEBUGGER_STATE Debugger;
        [FieldOffset(37056)]
        public _MI_STANDBY_STATE Standby;
        [FieldOffset(37440)]
        public _MI_SYSTEM_PTE_STATE SystemPtes;
        [FieldOffset(42816)]
        public _MI_IO_PAGE_STATE IoPages;
        [FieldOffset(43072)]
        public _MI_PAGING_IO_STATE PagingIo;
        [FieldOffset(43248)]
        public _MI_COMMON_PAGE_STATE CommonPages;
        [FieldOffset(43392)]
        public _MI_SYSTEM_TRIM_STATE Trims;
        [FieldOffset(43520)]
        public _MI_SYSTEM_ACCELERATORS Accelerators;
        [FieldOffset(43568)]
        public _MI_HOT_PATCH_STATE HotPatch;
        [FieldOffset(43640)]
        public _MI_ENCLAVE_STATE Enclaves;
        [FieldOffset(43712)]
        public ulong Cookie;
        [FieldOffset(43720)]
        public IntPtr BootRegistryRuns;
        [FieldOffset(43728)]
        public int ZeroingDisabled;
        [FieldOffset(43732)]
        public byte FullyInitialized;
        [FieldOffset(43733)]
        public byte SafeBooted;
        [FieldOffset(43736)]
        public IntPtr TraceLogging;
        [FieldOffset(43776)]
        public _MI_VISIBLE_STATE Vs;
    }
}