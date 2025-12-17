using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_DOMAIN_OBJECT")]
    public sealed class HalpDmaDomainObject : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public LargeInteger MaximumPhysicalAddress { get => ReadStructure<LargeInteger>(nameof(MaximumPhysicalAddress)); set => WriteStructure(nameof(MaximumPhysicalAddress), value); }

        [Offset(24UL)]
        public LargeInteger BoundaryAddressMultiple { get => ReadStructure<LargeInteger>(nameof(BoundaryAddressMultiple)); set => WriteStructure(nameof(BoundaryAddressMultiple), value); }

        [Offset(32UL)]
        public byte CacheCoherent { get => ReadHere<byte>(nameof(CacheCoherent)); set => WriteHere(nameof(CacheCoherent), value); }

        [Offset(33UL)]
        public byte FirmwareReserved { get => ReadHere<byte>(nameof(FirmwareReserved)); set => WriteHere(nameof(FirmwareReserved), value); }

        [Offset(40UL)]
        public IntPtr IommuDomainPointer { get => ReadHere<IntPtr>(nameof(IommuDomainPointer)); set => WriteHere(nameof(IommuDomainPointer), value); }

        [Offset(48UL)]
        public uint TranslationType { get => ReadHere<uint>(nameof(TranslationType)); set => WriteHere(nameof(TranslationType), value); }

        [Offset(56UL)]
        public IntPtr OwningAdapter { get => ReadHere<IntPtr>(nameof(OwningAdapter)); set => WriteHere(nameof(OwningAdapter), value); }

        [Offset(64UL)]
        public RtlRbTree CommonBufferRoot { get => ReadStructure<RtlRbTree>(nameof(CommonBufferRoot)); set => WriteStructure(nameof(CommonBufferRoot), value); }

        [Offset(80UL)]
        public ulong CommonBufferTreeLock { get => ReadHere<ulong>(nameof(CommonBufferTreeLock)); set => WriteHere(nameof(CommonBufferTreeLock), value); }

        [Offset(88UL)]
        public ListEntry VectorCommonBufferListHead { get => ReadStructure<ListEntry>(nameof(VectorCommonBufferListHead)); set => WriteStructure(nameof(VectorCommonBufferListHead), value); }

        [Offset(104UL)]
        public ulong VectorCommonBufferLock { get => ReadHere<ulong>(nameof(VectorCommonBufferLock)); set => WriteHere(nameof(VectorCommonBufferLock), value); }

        [Offset(112UL)]
        public uint DomainRefCount { get => ReadHere<uint>(nameof(DomainRefCount)); set => WriteHere(nameof(DomainRefCount), value); }

        public HalpDmaDomainObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpDmaDomainObject>();
        }
    }
}