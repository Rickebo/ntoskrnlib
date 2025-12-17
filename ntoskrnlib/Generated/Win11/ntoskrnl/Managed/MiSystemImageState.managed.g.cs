using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_IMAGE_STATE")]
    public sealed class MiSystemImageState : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry FixupList { get => ReadStructure<ListEntry>(nameof(FixupList)); set => WriteStructure(nameof(FixupList), value); }

        [Offset(16UL)]
        public IntPtr LoadLockOwner { get => ReadHere<IntPtr>(nameof(LoadLockOwner)); set => WriteHere(nameof(LoadLockOwner), value); }

        [Offset(24UL)]
        public uint LoadLockCount { get => ReadHere<uint>(nameof(LoadLockCount)); set => WriteHere(nameof(LoadLockCount), value); }

        [Offset(28UL)]
        public int FixupLock { get => ReadHere<int>(nameof(FixupLock)); set => WriteHere(nameof(FixupLock), value); }

        [Offset(32UL)]
        public ExPushLock EncodeDecodeLock { get => ReadStructure<ExPushLock>(nameof(EncodeDecodeLock)); set => WriteStructure(nameof(EncodeDecodeLock), value); }

        [Offset(40UL)]
        public uint EncodeDecodeDepth { get => ReadHere<uint>(nameof(EncodeDecodeDepth)); set => WriteHere(nameof(EncodeDecodeDepth), value); }

        [Offset(44UL)]
        public byte FirstLoadEver { get => ReadHere<byte>(nameof(FirstLoadEver)); set => WriteHere(nameof(FirstLoadEver), value); }

        [Offset(45UL)]
        public byte SystemImagesLoaded { get => ReadHere<byte>(nameof(SystemImagesLoaded)); set => WriteHere(nameof(SystemImagesLoaded), value); }

        [Offset(48UL)]
        public ListEntry StrongCodeLoadFailureList { get => ReadStructure<ListEntry>(nameof(StrongCodeLoadFailureList)); set => WriteStructure(nameof(StrongCodeLoadFailureList), value); }

        [Offset(64UL)]
        [Length(1)]
        public DynamicArray SystemBase { get => ReadStructure<DynamicArray>(nameof(SystemBase)); set => WriteStructure(nameof(SystemBase), value); }

        [Offset(72UL)]
        [Length(1)]
        public DynamicArray BaseImageDiscardedBitmaps { get => ReadStructure<DynamicArray>(nameof(BaseImageDiscardedBitmaps)); set => WriteStructure(nameof(BaseImageDiscardedBitmaps), value); }

        [Offset(88UL)]
        public ExPushLock MappingRangesPushLock { get => ReadStructure<ExPushLock>(nameof(MappingRangesPushLock)); set => WriteStructure(nameof(MappingRangesPushLock), value); }

        [Offset(96UL)]
        public IntPtr MappingRanges { get => ReadHere<IntPtr>(nameof(MappingRanges)); set => WriteHere(nameof(MappingRanges), value); }

        [Offset(104UL)]
        public MmSystemPageCounts PageCounts { get => ReadStructure<MmSystemPageCounts>(nameof(PageCounts)); set => WriteStructure(nameof(PageCounts), value); }

        [Offset(120UL)]
        public ExPushLock CollidedLock { get => ReadStructure<ExPushLock>(nameof(CollidedLock)); set => WriteStructure(nameof(CollidedLock), value); }

        [Offset(128UL)]
        public RtlAvlTree ImageTree { get => ReadStructure<RtlAvlTree>(nameof(ImageTree)); set => WriteStructure(nameof(ImageTree), value); }

        [Offset(136UL)]
        public ListEntry LoadInProgress { get => ReadStructure<ListEntry>(nameof(LoadInProgress)); set => WriteStructure(nameof(LoadInProgress), value); }

        [Offset(152UL)]
        public ulong ImportEntriesReplaced { get => ReadHere<ulong>(nameof(ImportEntriesReplaced)); set => WriteHere(nameof(ImportEntriesReplaced), value); }

        [Offset(160UL)]
        public ExPushLock SecurePteExclusionLock { get => ReadStructure<ExPushLock>(nameof(SecurePteExclusionLock)); set => WriteStructure(nameof(SecurePteExclusionLock), value); }

        [Offset(168UL)]
        public IntPtr SecurePteExclusionBase { get => ReadHere<IntPtr>(nameof(SecurePteExclusionBase)); set => WriteHere(nameof(SecurePteExclusionBase), value); }

        [Offset(176UL)]
        public IntPtr SecurePteExclusionTop { get => ReadHere<IntPtr>(nameof(SecurePteExclusionTop)); set => WriteHere(nameof(SecurePteExclusionTop), value); }

        [Offset(192UL)]
        [Length(4)]
        public DynamicArray WorkingSetLockArray { get => ReadStructure<DynamicArray>(nameof(WorkingSetLockArray)); set => WriteStructure(nameof(WorkingSetLockArray), value); }

        [Offset(448UL)]
        public RtlFunctionOverrideCapabilities FunctionOverrideCapabilities { get => ReadStructure<RtlFunctionOverrideCapabilities>(nameof(FunctionOverrideCapabilities)); set => WriteStructure(nameof(FunctionOverrideCapabilities), value); }

        public MiSystemImageState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemImageState>();
        }
    }
}