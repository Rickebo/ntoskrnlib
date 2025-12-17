using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_SVM_CAPABILITIES")]
    public sealed class IommuSvmCapabilities : DynamicStructure
    {
        [Offset(0UL)]
        public uint AtsCapability { get => ReadHere<uint>(nameof(AtsCapability)); set => WriteHere(nameof(AtsCapability), value); }

        [Offset(0UL)]
        public uint PriCapability { get => ReadHere<uint>(nameof(PriCapability)); set => WriteHere(nameof(PriCapability), value); }

        [Offset(0UL)]
        public uint PasidCapability { get => ReadHere<uint>(nameof(PasidCapability)); set => WriteHere(nameof(PasidCapability), value); }

        [Offset(0UL)]
        public uint Rsvd0 { get => ReadHere<uint>(nameof(Rsvd0)); set => WriteHere(nameof(Rsvd0), value); }

        [Offset(0UL)]
        public UnnamedTag CapReg { get => ReadStructure<UnnamedTag>(nameof(CapReg)); set => WriteStructure(nameof(CapReg), value); }

        [Offset(0UL)]
        public UnnamedTag EnabledCaps { get => ReadStructure<UnnamedTag>(nameof(EnabledCaps)); set => WriteStructure(nameof(EnabledCaps), value); }

        [Offset(0UL)]
        public UnnamedTag DeviceInformation { get => ReadStructure<UnnamedTag>(nameof(DeviceInformation)); set => WriteStructure(nameof(DeviceInformation), value); }

        [Offset(0UL)]
        public uint AtsPriPasidBits { get => ReadHere<uint>(nameof(AtsPriPasidBits)); set => WriteHere(nameof(AtsPriPasidBits), value); }

        [Offset(0UL)]
        public uint CapRegBits { get => ReadHere<uint>(nameof(CapRegBits)); set => WriteHere(nameof(CapRegBits), value); }

        [Offset(0UL)]
        public uint EnabledCapsBits { get => ReadHere<uint>(nameof(EnabledCapsBits)); set => WriteHere(nameof(EnabledCapsBits), value); }

        [Offset(0UL)]
        public uint DeviceInformationBits { get => ReadHere<uint>(nameof(DeviceInformationBits)); set => WriteHere(nameof(DeviceInformationBits), value); }

        [Offset(0UL)]
        public uint Rsvd1 { get => ReadHere<uint>(nameof(Rsvd1)); set => WriteHere(nameof(Rsvd1), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public IommuSvmCapabilities(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuSvmCapabilities>();
        }
    }
}