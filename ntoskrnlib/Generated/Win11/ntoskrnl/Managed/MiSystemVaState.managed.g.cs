using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_VA_STATE")]
    public sealed class MiSystemVaState : DynamicStructure
    {
        [Offset(0UL)]
        public int SystemTablesLock { get => ReadHere<int>(nameof(SystemTablesLock)); set => WriteHere(nameof(SystemTablesLock), value); }

        [Offset(8UL)]
        public ulong AvailableSystemCacheVa { get => ReadHere<ulong>(nameof(AvailableSystemCacheVa)); set => WriteHere(nameof(AvailableSystemCacheVa), value); }

        [Offset(16UL)]
        public MiDynamicBitmap DynamicBitMapKernelStacks { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapKernelStacks)); set => WriteStructure(nameof(DynamicBitMapKernelStacks), value); }

        [Offset(88UL)]
        public MiDynamicBitmap DynamicBitMapKernelShadowStacks { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapKernelShadowStacks)); set => WriteStructure(nameof(DynamicBitMapKernelShadowStacks), value); }

        [Offset(160UL)]
        public MiDynamicBitmap DynamicBitMapSystemPtes { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapSystemPtes)); set => WriteStructure(nameof(DynamicBitMapSystemPtes), value); }

        [Offset(232UL)]
        public MiDynamicBitmap DynamicBitMapNonCachedMappings { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapNonCachedMappings)); set => WriteStructure(nameof(DynamicBitMapNonCachedMappings), value); }

        [Offset(304UL)]
        public MiDynamicBitmap DynamicBitMapDriverImages { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapDriverImages)); set => WriteStructure(nameof(DynamicBitMapDriverImages), value); }

        [Offset(376UL)]
        public MiDynamicBitmap DynamicBitMapPagedPool { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapPagedPool)); set => WriteStructure(nameof(DynamicBitMapPagedPool), value); }

        [Offset(448UL)]
        public MiDynamicBitmap DynamicBitMapSystemCache { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapSystemCache)); set => WriteStructure(nameof(DynamicBitMapSystemCache), value); }

        [Offset(520UL)]
        public MiDynamicBitmap DynamicBitMapSystemDataViews { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapSystemDataViews)); set => WriteStructure(nameof(DynamicBitMapSystemDataViews), value); }

        [Offset(592UL)]
        public MiDynamicBitmap DynamicBitMapSecureNonPagedPool { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapSecureNonPagedPool)); set => WriteStructure(nameof(DynamicBitMapSecureNonPagedPool), value); }

        [Offset(664UL)]
        public IntPtr HalPrivateVaStart { get => ReadHere<IntPtr>(nameof(HalPrivateVaStart)); set => WriteHere(nameof(HalPrivateVaStart), value); }

        [Offset(672UL)]
        public ulong HalPrivateVaSize { get => ReadHere<ulong>(nameof(HalPrivateVaSize)); set => WriteHere(nameof(HalPrivateVaSize), value); }

        [Offset(680UL)]
        [Length(8)]
        public DynamicArray SystemVaAssignment { get => ReadStructure<DynamicArray>(nameof(SystemVaAssignment)); set => WriteStructure(nameof(SystemVaAssignment), value); }

        [Offset(712UL)]
        public uint SystemVaAssignmentHint { get => ReadHere<uint>(nameof(SystemVaAssignmentHint)); set => WriteHere(nameof(SystemVaAssignmentHint), value); }

        [Offset(716UL)]
        [Length(8)]
        public DynamicArray VaRegionShadowed { get => ReadStructure<DynamicArray>(nameof(VaRegionShadowed)); set => WriteStructure(nameof(VaRegionShadowed), value); }

        [Offset(748UL)]
        [Length(32)]
        public DynamicArray TopLevelPteLockBits { get => ReadStructure<DynamicArray>(nameof(TopLevelPteLockBits)); set => WriteStructure(nameof(TopLevelPteLockBits), value); }

        [Offset(896UL)]
        public MmsupportFull SoftWsleSystemVm { get => ReadStructure<MmsupportFull>(nameof(SoftWsleSystemVm)); set => WriteStructure(nameof(SoftWsleSystemVm), value); }

        [Offset(1216UL)]
        public IntPtr HyperSpaceBase { get => ReadHere<IntPtr>(nameof(HyperSpaceBase)); set => WriteHere(nameof(HyperSpaceBase), value); }

        [Offset(1224UL)]
        public IntPtr PagableHyperSpace { get => ReadHere<IntPtr>(nameof(PagableHyperSpace)); set => WriteHere(nameof(PagableHyperSpace), value); }

        [Offset(1232UL)]
        public IntPtr HyperSpaceEnd { get => ReadHere<IntPtr>(nameof(HyperSpaceEnd)); set => WriteHere(nameof(HyperSpaceEnd), value); }

        [Offset(1240UL)]
        public IntPtr UserSoftWsleBase { get => ReadHere<IntPtr>(nameof(UserSoftWsleBase)); set => WriteHere(nameof(UserSoftWsleBase), value); }

        [Offset(1248UL)]
        public ulong PagableHyperSpaceBytes { get => ReadHere<ulong>(nameof(PagableHyperSpaceBytes)); set => WriteHere(nameof(PagableHyperSpaceBytes), value); }

        [Offset(1256UL)]
        [Length(2)]
        public DynamicArray PageTableCommitmentOffset { get => ReadStructure<DynamicArray>(nameof(PageTableCommitmentOffset)); set => WriteStructure(nameof(PageTableCommitmentOffset), value); }

        [Offset(1272UL)]
        public int SystemCacheViewLock { get => ReadHere<int>(nameof(SystemCacheViewLock)); set => WriteHere(nameof(SystemCacheViewLock), value); }

        [Offset(1280UL)]
        [Length(10)]
        public DynamicArray SystemWorkingSetList { get => ReadStructure<DynamicArray>(nameof(SystemWorkingSetList)); set => WriteStructure(nameof(SystemWorkingSetList), value); }

        [Offset(3840UL)]
        [Length(4)]
        public DynamicArray SelfmapLock { get => ReadStructure<DynamicArray>(nameof(SelfmapLock)); set => WriteStructure(nameof(SelfmapLock), value); }

        [Offset(3904UL)]
        [Length(4)]
        public DynamicArray SystemCacheWorkingSetLockArray { get => ReadStructure<DynamicArray>(nameof(SystemCacheWorkingSetLockArray)); set => WriteStructure(nameof(SystemCacheWorkingSetLockArray), value); }

        public MiSystemVaState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemVaState>();
        }
    }
}