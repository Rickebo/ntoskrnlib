using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_SLABS")]
    public sealed class MiPartitionSlabs : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SlabTypeIdentifiers { get => ReadHere<IntPtr>(nameof(SlabTypeIdentifiers)); set => WriteHere(nameof(SlabTypeIdentifiers), value); }

        [Offset(8UL)]
        public ulong SlabEntriesDemoted { get => ReadHere<ulong>(nameof(SlabEntriesDemoted)); set => WriteHere(nameof(SlabEntriesDemoted), value); }

        [Offset(16UL)]
        public int SlabDemoteInProgress { get => ReadHere<int>(nameof(SlabDemoteInProgress)); set => WriteHere(nameof(SlabDemoteInProgress), value); }

        [Offset(20UL)]
        public uint SlabTypeAcquiresCharges { get => ReadHere<uint>(nameof(SlabTypeAcquiresCharges)); set => WriteHere(nameof(SlabTypeAcquiresCharges), value); }

        [Offset(24UL)]
        [Length(64)]
        public DynamicArray IdentityRefs { get => ReadStructure<DynamicArray>(nameof(IdentityRefs)); set => WriteStructure(nameof(IdentityRefs), value); }

        [Offset(536UL)]
        public RtlBitmap InUseIdentitiesBitmap { get => ReadStructure<RtlBitmap>(nameof(InUseIdentitiesBitmap)); set => WriteStructure(nameof(InUseIdentitiesBitmap), value); }

        [Offset(552UL)]
        [Length(2)]
        public DynamicArray InUseIdentitiesBitmapBuffer { get => ReadStructure<DynamicArray>(nameof(InUseIdentitiesBitmapBuffer)); set => WriteStructure(nameof(InUseIdentitiesBitmapBuffer), value); }

        [Offset(560UL)]
        public int IdentitySlabsInitialized { get => ReadHere<int>(nameof(IdentitySlabsInitialized)); set => WriteHere(nameof(IdentitySlabsInitialized), value); }

        [Offset(568UL)]
        public ExPushLock IdentitiesLock { get => ReadStructure<ExPushLock>(nameof(IdentitiesLock)); set => WriteStructure(nameof(IdentitiesLock), value); }

        [Offset(576UL)]
        public ulong IdentitySlabAvailablePages { get => ReadHere<ulong>(nameof(IdentitySlabAvailablePages)); set => WriteHere(nameof(IdentitySlabAvailablePages), value); }

        [Offset(584UL)]
        [Length(2)]
        public DynamicArray IdentitySlabAvailablePagesWaitState { get => ReadStructure<DynamicArray>(nameof(IdentitySlabAvailablePagesWaitState)); set => WriteStructure(nameof(IdentitySlabAvailablePagesWaitState), value); }

        [Offset(648UL)]
        public ExRundownRef ReplenishRundownProtection { get => ReadStructure<ExRundownRef>(nameof(ReplenishRundownProtection)); set => WriteStructure(nameof(ReplenishRundownProtection), value); }

        [Offset(656UL)]
        public ulong LowMemoryConditionStartTime { get => ReadHere<ulong>(nameof(LowMemoryConditionStartTime)); set => WriteHere(nameof(LowMemoryConditionStartTime), value); }

        public MiPartitionSlabs(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionSlabs>();
        }
    }
}