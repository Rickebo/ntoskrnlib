using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DOMAIN")]
    public sealed class ExtIommuDomain : DynamicStructure
    {
        [Offset(0UL)]
        public uint DomainType { get => ReadHere<uint>(nameof(DomainType)); set => WriteHere(nameof(DomainType), value); }

        [Offset(4UL)]
        public uint TranslationType { get => ReadHere<uint>(nameof(TranslationType)); set => WriteHere(nameof(TranslationType), value); }

        [Offset(8UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(10UL)]
        public ushort FirmwareDomainId { get => ReadHere<ushort>(nameof(FirmwareDomainId)); set => WriteHere(nameof(FirmwareDomainId), value); }

        [Offset(16UL)]
        public ExtIommuDomainSettings Settings { get => ReadStructure<ExtIommuDomainSettings>(nameof(Settings)); set => WriteStructure(nameof(Settings), value); }

        [Offset(48UL)]
        public uint ContextId { get => ReadHere<uint>(nameof(ContextId)); set => WriteHere(nameof(ContextId), value); }

        [Offset(52UL)]
        public uint DeviceCount { get => ReadHere<uint>(nameof(DeviceCount)); set => WriteHere(nameof(DeviceCount), value); }

        [Offset(56UL)]
        public ListEntry Devices { get => ReadStructure<ListEntry>(nameof(Devices)); set => WriteStructure(nameof(Devices), value); }

        [Offset(72UL)]
        public ExtEnvSpinlock Lock { get => ReadStructure<ExtEnvSpinlock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(104UL)]
        public IntPtr S2Domain { get => ReadHere<IntPtr>(nameof(S2Domain)); set => WriteHere(nameof(S2Domain), value); }

        public ExtIommuDomain(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuDomain>();
        }
    }
}