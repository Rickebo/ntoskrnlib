using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_DOMAIN")]
    public sealed class IommuDmaDomain : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DmaDomainOwner { get => ReadHere<IntPtr>(nameof(DmaDomainOwner)); set => WriteHere(nameof(DmaDomainOwner), value); }

        [Offset(8UL)]
        public uint DomainType { get => ReadHere<uint>(nameof(DomainType)); set => WriteHere(nameof(DomainType), value); }

        [Offset(12UL)]
        public uint TranslationType { get => ReadHere<uint>(nameof(TranslationType)); set => WriteHere(nameof(TranslationType), value); }

        [Offset(16UL)]
        public ListEntry HardwareDomainListHead { get => ReadStructure<ListEntry>(nameof(HardwareDomainListHead)); set => WriteStructure(nameof(HardwareDomainListHead), value); }

        [Offset(32UL)]
        public ulong HardwareDomainListLock { get => ReadHere<ulong>(nameof(HardwareDomainListLock)); set => WriteHere(nameof(HardwareDomainListLock), value); }

        [Offset(40UL)]
        public IntPtr DmarptState { get => ReadHere<IntPtr>(nameof(DmarptState)); set => WriteHere(nameof(DmarptState), value); }

        [Offset(48UL)]
        public uint DomainId { get => ReadHere<uint>(nameof(DomainId)); set => WriteHere(nameof(DomainId), value); }

        [Offset(52UL)]
        public byte IsStage1 { get => ReadHere<byte>(nameof(IsStage1)); set => WriteHere(nameof(IsStage1), value); }

        [Offset(56UL)]
        public uint Asid { get => ReadHere<uint>(nameof(Asid)); set => WriteHere(nameof(Asid), value); }

        [Offset(64UL)]
        public IntPtr LogicalAllocator { get => ReadHere<IntPtr>(nameof(LogicalAllocator)); set => WriteHere(nameof(LogicalAllocator), value); }

        [Offset(72UL)]
        public ListEntry AttachedDevicesList { get => ReadStructure<ListEntry>(nameof(AttachedDevicesList)); set => WriteStructure(nameof(AttachedDevicesList), value); }

        [Offset(88UL)]
        public int AttachedDevicesListLock { get => ReadHere<int>(nameof(AttachedDevicesListLock)); set => WriteHere(nameof(AttachedDevicesListLock), value); }

        [Offset(92UL)]
        public uint HvReferences { get => ReadHere<uint>(nameof(HvReferences)); set => WriteHere(nameof(HvReferences), value); }

        [Offset(96UL)]
        public byte HvDomainIdAllocated { get => ReadHere<byte>(nameof(HvDomainIdAllocated)); set => WriteHere(nameof(HvDomainIdAllocated), value); }

        [Offset(104UL)]
        public ExPushLock HvPushLock { get => ReadStructure<ExPushLock>(nameof(HvPushLock)); set => WriteStructure(nameof(HvPushLock), value); }

        public IommuDmaDomain(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaDomain>();
        }
    }
}