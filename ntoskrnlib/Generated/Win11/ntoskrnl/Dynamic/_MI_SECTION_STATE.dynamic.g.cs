using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SECTION_STATE")]
    public sealed class _MI_SECTION_STATE : DynamicStructure
    {
        public int SectionObjectPointersLock { get; }
        public _RTL_AVL_TREE SectionBasedRoot { get; }
        public _EX_PUSH_LOCK SectionBasedLock { get; }
        public ulong UnusedSegmentPagedPool { get; }
        public int CalibrationIndex { get; }
        public byte[] CalibrationData { get; }
        public uint DataSectionProtectionMask { get; }
        public IntPtr HighSectionBase { get; }
        public _MSUBSECTION PhysicalSubsection { get; }
        public _CONTROL_AREA PhysicalControlArea { get; }
        public _MMPFNLIST PurgingExtentPages { get; }
        public _MI_PAGE_CHAIN_HEAD DanglingExtentPages { get; }
        public _WORK_QUEUE_ITEM DanglingExtentsWorkItem { get; }
        public _MI_EXTENT_DELETION_WAIT_BLOCK DanglingExtentsDeletionWaitList { get; }
        public byte FileOnlyMemoryPfnsCreated { get; }
        public byte DanglingExtentsWorkerActive { get; }
        public byte PurgingExtentsNeedWatchdog { get; }
        public _RTL_AVL_TREE PrototypePtesTree { get; }
        public int PrototypePtesTreeSpinLock { get; }
        public _EX_PUSH_LOCK PrivateFixupMappingLock { get; }
        public IntPtr PrivateFixupPte { get; }
        public _EX_PUSH_LOCK RelocateBitmapsLock { get; }
        public _RTL_BITMAP_EX ImageBitMapNative { get; }
        public ulong ImageBiasNative { get; }
        public _MI_DLL_OVERFLOW_AREA OverflowArea { get; }
        public byte[] Wow { get; }
        public ulong ImageBiasWow { get; }
        public _RTL_BITMAP_EX ImageBitMapWowScratch { get; }
        public _RTL_BITMAP_EX ImageBitMap64Low { get; }
        public ulong ImageBias64Low { get; }
        public IntPtr ApiSetSection { get; }
        public IntPtr ApiSetSchema { get; }
        public ulong ApiSetSchemaSize { get; }
        public uint LostDataFiles { get; }
        public uint LostDataPages { get; }
        public uint ImageFailureReason { get; }
        public IntPtr CfgBitMapSection { get; }
        public IntPtr CfgBitMapControlArea { get; }
        public _RTL_BITMAP_EX KernelCfgBitMap { get; }
        public _EX_PUSH_LOCK KernelCfgBitMapLock { get; }
        public uint ImageCfgFailure { get; }
        public IntPtr KernelScpStartAddress { get; }
        public uint KernelScpReservePages { get; }
        public uint KernelScpPages { get; }
        public IntPtr KernelScpMdl { get; }
        public int RetpolineBootStatus { get; }
        public IntPtr RetpolineRevertPte { get; }
        public _RTL_BITMAP_EX KernelRetpolineBitMap { get; }
        public _LIST_ENTRY NonRetpolineImageLoadList { get; }
        public uint ImageBreakpointEnabled { get; }
        public uint ImageBreakpointChecksum { get; }
        public uint ImageBreakpointSize { get; }
        public int ImageValidationFailed { get; }
        public byte[] ExtentTree { get; }
        public _EX_PUSH_LOCK ExtentTreeLock { get; }
        public uint[] ImageViewExtensionOffsets { get; }
        public uint TotalImageViewExtensionSize { get; }
        public uint TotalImageViewReservationSize { get; }
        public byte[] ScpCfgPages { get; }
        public byte[] EmulatedScpCfgPages { get; }

        public _MI_SECTION_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SECTION_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SECTION_STATE.SectionObjectPointersLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.SectionBasedRoot),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.SectionBasedLock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.UnusedSegmentPagedPool),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.CalibrationIndex),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.CalibrationData),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.DataSectionProtectionMask),
                    new ulong[]
                    {
                        2088UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.HighSectionBase),
                    new ulong[]
                    {
                        2096UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.PhysicalSubsection),
                    new ulong[]
                    {
                        2104UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.PhysicalControlArea),
                    new ulong[]
                    {
                        2256UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.PurgingExtentPages),
                    new ulong[]
                    {
                        2384UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.DanglingExtentPages),
                    new ulong[]
                    {
                        2472UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.DanglingExtentsWorkItem),
                    new ulong[]
                    {
                        2496UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.DanglingExtentsDeletionWaitList),
                    new ulong[]
                    {
                        2528UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.FileOnlyMemoryPfnsCreated),
                    new ulong[]
                    {
                        2560UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.DanglingExtentsWorkerActive),
                    new ulong[]
                    {
                        2561UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.PurgingExtentsNeedWatchdog),
                    new ulong[]
                    {
                        2562UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.PrototypePtesTree),
                    new ulong[]
                    {
                        2568UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.PrototypePtesTreeSpinLock),
                    new ulong[]
                    {
                        2576UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.PrivateFixupMappingLock),
                    new ulong[]
                    {
                        2584UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.PrivateFixupPte),
                    new ulong[]
                    {
                        2592UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.RelocateBitmapsLock),
                    new ulong[]
                    {
                        2600UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBitMapNative),
                    new ulong[]
                    {
                        2608UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBiasNative),
                    new ulong[]
                    {
                        2624UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.OverflowArea),
                    new ulong[]
                    {
                        2632UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.Wow),
                    new ulong[]
                    {
                        2664UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBiasWow),
                    new ulong[]
                    {
                        2728UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBitMapWowScratch),
                    new ulong[]
                    {
                        2736UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBitMap64Low),
                    new ulong[]
                    {
                        2752UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBias64Low),
                    new ulong[]
                    {
                        2768UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ApiSetSection),
                    new ulong[]
                    {
                        2776UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ApiSetSchema),
                    new ulong[]
                    {
                        2784UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ApiSetSchemaSize),
                    new ulong[]
                    {
                        2792UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.LostDataFiles),
                    new ulong[]
                    {
                        2800UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.LostDataPages),
                    new ulong[]
                    {
                        2804UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageFailureReason),
                    new ulong[]
                    {
                        2808UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.CfgBitMapSection),
                    new ulong[]
                    {
                        2816UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.CfgBitMapControlArea),
                    new ulong[]
                    {
                        2824UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.KernelCfgBitMap),
                    new ulong[]
                    {
                        2832UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.KernelCfgBitMapLock),
                    new ulong[]
                    {
                        2848UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageCfgFailure),
                    new ulong[]
                    {
                        2856UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.KernelScpStartAddress),
                    new ulong[]
                    {
                        2864UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.KernelScpReservePages),
                    new ulong[]
                    {
                        2872UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.KernelScpPages),
                    new ulong[]
                    {
                        2876UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.KernelScpMdl),
                    new ulong[]
                    {
                        2880UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.RetpolineBootStatus),
                    new ulong[]
                    {
                        2888UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.RetpolineRevertPte),
                    new ulong[]
                    {
                        2896UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.KernelRetpolineBitMap),
                    new ulong[]
                    {
                        2904UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.NonRetpolineImageLoadList),
                    new ulong[]
                    {
                        2920UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBreakpointEnabled),
                    new ulong[]
                    {
                        2936UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBreakpointChecksum),
                    new ulong[]
                    {
                        2940UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageBreakpointSize),
                    new ulong[]
                    {
                        2944UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageValidationFailed),
                    new ulong[]
                    {
                        2948UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ExtentTree),
                    new ulong[]
                    {
                        2952UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ExtentTreeLock),
                    new ulong[]
                    {
                        2968UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ImageViewExtensionOffsets),
                    new ulong[]
                    {
                        2976UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.TotalImageViewExtensionSize),
                    new ulong[]
                    {
                        2988UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.TotalImageViewReservationSize),
                    new ulong[]
                    {
                        2992UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.ScpCfgPages),
                    new ulong[]
                    {
                        3000UL
                    }
                },
                {
                    nameof(_MI_SECTION_STATE.EmulatedScpCfgPages),
                    new ulong[]
                    {
                        3032UL
                    }
                }
            };
            Register<_MI_SECTION_STATE>((mem, ptr) => new _MI_SECTION_STATE(mem, ptr), offsets);
        }
    }
}