using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_FLAGS")]
    public sealed class MiPartitionFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint BeingDeleted { get => ReadHere<uint>(nameof(BeingDeleted)); set => WriteHere(nameof(BeingDeleted), value); }

        [Offset(0UL)]
        public uint PageListsInitialized { get => ReadHere<uint>(nameof(PageListsInitialized)); set => WriteHere(nameof(PageListsInitialized), value); }

        [Offset(0UL)]
        public uint StoreReservedPagesCharged { get => ReadHere<uint>(nameof(StoreReservedPagesCharged)); set => WriteHere(nameof(StoreReservedPagesCharged), value); }

        [Offset(0UL)]
        public uint UseProtectedSlabAllocators { get => ReadHere<uint>(nameof(UseProtectedSlabAllocators)); set => WriteHere(nameof(UseProtectedSlabAllocators), value); }

        [Offset(0UL)]
        public uint PureHolding { get => ReadHere<uint>(nameof(PureHolding)); set => WriteHere(nameof(PureHolding), value); }

        [Offset(0UL)]
        public uint ZeroPagesOptional { get => ReadHere<uint>(nameof(ZeroPagesOptional)); set => WriteHere(nameof(ZeroPagesOptional), value); }

        [Offset(0UL)]
        public uint BackgroundZeroingDisabled { get => ReadHere<uint>(nameof(BackgroundZeroingDisabled)); set => WriteHere(nameof(BackgroundZeroingDisabled), value); }

        [Offset(0UL)]
        public uint SpecialPurposeMemory { get => ReadHere<uint>(nameof(SpecialPurposeMemory)); set => WriteHere(nameof(SpecialPurposeMemory), value); }

        [Offset(0UL)]
        public int EntireField { get => ReadHere<int>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MiPartitionFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionFlags>();
        }
    }
}