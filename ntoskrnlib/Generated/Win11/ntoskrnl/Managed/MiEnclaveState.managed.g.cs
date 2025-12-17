using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ENCLAVE_STATE")]
    public sealed class MiEnclaveState : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTree EnclaveRegions { get => ReadStructure<RtlAvlTree>(nameof(EnclaveRegions)); set => WriteStructure(nameof(EnclaveRegions), value); }

        [Offset(8UL)]
        public IntPtr EnclaveMetadataPage { get => ReadHere<IntPtr>(nameof(EnclaveMetadataPage)); set => WriteHere(nameof(EnclaveMetadataPage), value); }

        [Offset(16UL)]
        public IntPtr EnclaveMetadataBitMap { get => ReadHere<IntPtr>(nameof(EnclaveMetadataBitMap)); set => WriteHere(nameof(EnclaveMetadataBitMap), value); }

        [Offset(24UL)]
        public ExPushLock EnclaveMetadataEntryLock { get => ReadStructure<ExPushLock>(nameof(EnclaveMetadataEntryLock)); set => WriteStructure(nameof(EnclaveMetadataEntryLock), value); }

        [Offset(32UL)]
        public int EnclaveMetadataPageLock { get => ReadHere<int>(nameof(EnclaveMetadataPageLock)); set => WriteHere(nameof(EnclaveMetadataPageLock), value); }

        [Offset(40UL)]
        public ListEntry EnclaveList { get => ReadStructure<ListEntry>(nameof(EnclaveList)); set => WriteStructure(nameof(EnclaveList), value); }

        [Offset(56UL)]
        public ExPushLock EnclaveListLock { get => ReadStructure<ExPushLock>(nameof(EnclaveListLock)); set => WriteStructure(nameof(EnclaveListLock), value); }

        [Offset(64UL)]
        public ExRundownRef ShutdownRundown { get => ReadStructure<ExRundownRef>(nameof(ShutdownRundown)); set => WriteStructure(nameof(ShutdownRundown), value); }

        public MiEnclaveState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiEnclaveState>();
        }
    }
}