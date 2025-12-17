#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 14560)]
    public partial struct _RTLP_HP_HEAP_MANAGER
    {
        [FieldOffset(0)]
        public IntPtr Globals;
        [FieldOffset(8)]
        public _RTLP_HP_ALLOC_TRACKER AllocTracker;
        [FieldOffset(88)]
        public _HEAP_VAMGR_CTX VaMgr;
        [FieldOffset(14488)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _RTLP_HP_METADATA_HEAP_CTX[] MetadataHeaps;
        [FieldOffset(14552)]
        public _RTL_HP_SUB_ALLOCATOR_CONFIGS SubAllocConfigs;
    }
}