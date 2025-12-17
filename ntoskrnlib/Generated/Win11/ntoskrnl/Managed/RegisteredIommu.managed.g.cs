using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_REGISTERED_IOMMU")]
    public sealed class RegisteredIommu : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr InternalData { get => ReadHere<IntPtr>(nameof(InternalData)); set => WriteHere(nameof(InternalData), value); }

        [Offset(24UL)]
        public uint InternalDataSize { get => ReadHere<uint>(nameof(InternalDataSize)); set => WriteHere(nameof(InternalDataSize), value); }

        [Offset(32UL)]
        public IntPtr InterruptContext { get => ReadHere<IntPtr>(nameof(InterruptContext)); set => WriteHere(nameof(InterruptContext), value); }

        [Offset(40UL)]
        public byte Irql { get => ReadHere<byte>(nameof(Irql)); set => WriteHere(nameof(Irql), value); }

        [Offset(44UL)]
        public int Gsi { get => ReadHere<int>(nameof(Gsi)); set => WriteHere(nameof(Gsi), value); }

        [Offset(48UL)]
        public uint InterruptPolarity { get => ReadHere<uint>(nameof(InterruptPolarity)); set => WriteHere(nameof(InterruptPolarity), value); }

        [Offset(52UL)]
        public uint InterruptMode { get => ReadHere<uint>(nameof(InterruptMode)); set => WriteHere(nameof(InterruptMode), value); }

        [Offset(56UL)]
        public ExtIommuFunctionTable FunctionTable { get => ReadStructure<ExtIommuFunctionTable>(nameof(FunctionTable)); set => WriteStructure(nameof(FunctionTable), value); }

        [Offset(208UL)]
        public ExtIommuFunctionTableExtended FunctionTableExtended { get => ReadStructure<ExtIommuFunctionTableExtended>(nameof(FunctionTableExtended)); set => WriteStructure(nameof(FunctionTableExtended), value); }

        [Offset(392UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(400UL)]
        public IommuPageHandlingData PageHandling { get => ReadStructure<IommuPageHandlingData>(nameof(PageHandling)); set => WriteStructure(nameof(PageHandling), value); }

        [Offset(440UL)]
        public uint MaximumDomainIds { get => ReadHere<uint>(nameof(MaximumDomainIds)); set => WriteHere(nameof(MaximumDomainIds), value); }

        [Offset(448UL)]
        public ulong DomainIdBitmapLock { get => ReadHere<ulong>(nameof(DomainIdBitmapLock)); set => WriteHere(nameof(DomainIdBitmapLock), value); }

        [Offset(456UL)]
        public RtlBitmap DomainIdBitmap { get => ReadStructure<RtlBitmap>(nameof(DomainIdBitmap)); set => WriteStructure(nameof(DomainIdBitmap), value); }

        [Offset(472UL)]
        public uint Capabilities { get => ReadHere<uint>(nameof(Capabilities)); set => WriteHere(nameof(Capabilities), value); }

        [Offset(476UL)]
        public uint KnownType { get => ReadHere<uint>(nameof(KnownType)); set => WriteHere(nameof(KnownType), value); }

        [Offset(480UL)]
        public uint PciSegment { get => ReadHere<uint>(nameof(PciSegment)); set => WriteHere(nameof(PciSegment), value); }

        [Offset(484UL)]
        public uint PciBus { get => ReadHere<uint>(nameof(PciBus)); set => WriteHere(nameof(PciBus), value); }

        [Offset(488UL)]
        public PciSlotNumber PciSlot { get => ReadStructure<PciSlotNumber>(nameof(PciSlot)); set => WriteStructure(nameof(PciSlot), value); }

        [Offset(496UL)]
        public LargeInteger MsiAddress { get => ReadStructure<LargeInteger>(nameof(MsiAddress)); set => WriteStructure(nameof(MsiAddress), value); }

        [Offset(504UL)]
        public ulong MsiData { get => ReadHere<ulong>(nameof(MsiData)); set => WriteHere(nameof(MsiData), value); }

        [Offset(512UL)]
        public uint MaximumAsids { get => ReadHere<uint>(nameof(MaximumAsids)); set => WriteHere(nameof(MaximumAsids), value); }

        [Offset(516UL)]
        public uint Identifier { get => ReadHere<uint>(nameof(Identifier)); set => WriteHere(nameof(Identifier), value); }

        [Offset(520UL)]
        public UnicodeString ResourceId { get => ReadStructure<UnicodeString>(nameof(ResourceId)); set => WriteStructure(nameof(ResourceId), value); }

        [Offset(536UL)]
        public IntPtr ReservedDevices { get => ReadHere<IntPtr>(nameof(ReservedDevices)); set => WriteHere(nameof(ReservedDevices), value); }

        public RegisteredIommu(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RegisteredIommu>();
        }
    }
}