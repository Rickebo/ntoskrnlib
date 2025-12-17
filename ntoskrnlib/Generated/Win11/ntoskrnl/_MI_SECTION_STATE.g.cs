#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 3072)]
    public partial struct _MI_SECTION_STATE
    {
        [FieldOffset(0)]
        public int SectionObjectPointersLock;
        [FieldOffset(8)]
        public _RTL_AVL_TREE SectionBasedRoot;
        [FieldOffset(16)]
        public _EX_PUSH_LOCK SectionBasedLock;
        [FieldOffset(24)]
        public ulong UnusedSegmentPagedPool;
        [FieldOffset(32)]
        public int CalibrationIndex;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _MI_UNUSED_SEGMENT_TRACES[] CalibrationData;
        [FieldOffset(2088)]
        public uint DataSectionProtectionMask;
        [FieldOffset(2096)]
        public IntPtr HighSectionBase;
        [FieldOffset(2104)]
        public _MSUBSECTION PhysicalSubsection;
        [FieldOffset(2256)]
        public _CONTROL_AREA PhysicalControlArea;
        [FieldOffset(2384)]
        public _MMPFNLIST PurgingExtentPages;
        [FieldOffset(2472)]
        public _MI_PAGE_CHAIN_HEAD DanglingExtentPages;
        [FieldOffset(2496)]
        public _WORK_QUEUE_ITEM DanglingExtentsWorkItem;
        [FieldOffset(2528)]
        public _MI_EXTENT_DELETION_WAIT_BLOCK DanglingExtentsDeletionWaitList;
        [FieldOffset(2560)]
        public byte FileOnlyMemoryPfnsCreated;
        [FieldOffset(2561)]
        public byte DanglingExtentsWorkerActive;
        [FieldOffset(2562)]
        public byte PurgingExtentsNeedWatchdog;
        [FieldOffset(2568)]
        public _RTL_AVL_TREE PrototypePtesTree;
        [FieldOffset(2576)]
        public int PrototypePtesTreeSpinLock;
        [FieldOffset(2584)]
        public _EX_PUSH_LOCK PrivateFixupMappingLock;
        [FieldOffset(2592)]
        public IntPtr PrivateFixupPte;
        [FieldOffset(2600)]
        public _EX_PUSH_LOCK RelocateBitmapsLock;
        [FieldOffset(2608)]
        public _RTL_BITMAP_EX ImageBitMapNative;
        [FieldOffset(2624)]
        public ulong ImageBiasNative;
        [FieldOffset(2632)]
        public _MI_DLL_OVERFLOW_AREA OverflowArea;
        [FieldOffset(2664)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _MI_SECTION_WOW_STATE[] Wow;
        [FieldOffset(2728)]
        public ulong ImageBiasWow;
        [FieldOffset(2736)]
        public _RTL_BITMAP_EX ImageBitMapWowScratch;
        [FieldOffset(2752)]
        public _RTL_BITMAP_EX ImageBitMap64Low;
        [FieldOffset(2768)]
        public ulong ImageBias64Low;
        [FieldOffset(2776)]
        public IntPtr ApiSetSection;
        [FieldOffset(2784)]
        public IntPtr ApiSetSchema;
        [FieldOffset(2792)]
        public ulong ApiSetSchemaSize;
        [FieldOffset(2800)]
        public uint LostDataFiles;
        [FieldOffset(2804)]
        public uint LostDataPages;
        [FieldOffset(2808)]
        public uint ImageFailureReason;
        [FieldOffset(2816)]
        public IntPtr CfgBitMapSection;
        [FieldOffset(2824)]
        public IntPtr CfgBitMapControlArea;
        [FieldOffset(2832)]
        public _RTL_BITMAP_EX KernelCfgBitMap;
        [FieldOffset(2848)]
        public _EX_PUSH_LOCK KernelCfgBitMapLock;
        [FieldOffset(2856)]
        public uint ImageCfgFailure;
        [FieldOffset(2864)]
        public IntPtr KernelScpStartAddress;
        [FieldOffset(2872)]
        public uint KernelScpReservePages;
        [FieldOffset(2876)]
        public uint KernelScpPages;
        [FieldOffset(2880)]
        public IntPtr KernelScpMdl;
        [FieldOffset(2888)]
        public int RetpolineBootStatus;
        [FieldOffset(2896)]
        public IntPtr RetpolineRevertPte;
        [FieldOffset(2904)]
        public _RTL_BITMAP_EX KernelRetpolineBitMap;
        [FieldOffset(2920)]
        public _LIST_ENTRY NonRetpolineImageLoadList;
        [FieldOffset(2936)]
        public uint ImageBreakpointEnabled;
        [FieldOffset(2940)]
        public uint ImageBreakpointChecksum;
        [FieldOffset(2944)]
        public uint ImageBreakpointSize;
        [FieldOffset(2948)]
        public int ImageValidationFailed;
        [FieldOffset(2952)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _RTL_AVL_TREE[] ExtentTree;
        [FieldOffset(2968)]
        public _EX_PUSH_LOCK ExtentTreeLock;
        [FieldOffset(2976)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] ImageViewExtensionOffsets;
        [FieldOffset(2988)]
        public uint TotalImageViewExtensionSize;
        [FieldOffset(2992)]
        public uint TotalImageViewReservationSize;
        [FieldOffset(3000)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] ScpCfgPages;
        [FieldOffset(3032)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] EmulatedScpCfgPages;
    }
}