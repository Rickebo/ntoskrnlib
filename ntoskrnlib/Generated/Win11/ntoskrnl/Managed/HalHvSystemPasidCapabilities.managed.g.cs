using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_HV_SYSTEM_PASID_CAPABILITIES")]
    public sealed class HalHvSystemPasidCapabilities : DynamicStructure
    {
        [Offset(0UL)]
        public uint SvmSupported { get => ReadHere<uint>(nameof(SvmSupported)); set => WriteHere(nameof(SvmSupported), value); }

        [Offset(0UL)]
        public uint GpaAlwaysValid { get => ReadHere<uint>(nameof(GpaAlwaysValid)); set => WriteHere(nameof(GpaAlwaysValid), value); }

        [Offset(0UL)]
        public uint PasidSupported { get => ReadHere<uint>(nameof(PasidSupported)); set => WriteHere(nameof(PasidSupported), value); }

        [Offset(4UL)]
        public uint MaxPasidSpacePasidCount { get => ReadHere<uint>(nameof(MaxPasidSpacePasidCount)); set => WriteHere(nameof(MaxPasidSpacePasidCount), value); }

        [Offset(8UL)]
        public uint MaxPrqSize { get => ReadHere<uint>(nameof(MaxPrqSize)); set => WriteHere(nameof(MaxPrqSize), value); }

        [Offset(12UL)]
        public uint SvmIommuCount { get => ReadHere<uint>(nameof(SvmIommuCount)); set => WriteHere(nameof(SvmIommuCount), value); }

        [Offset(16UL)]
        public uint MinIommuPasidCount { get => ReadHere<uint>(nameof(MinIommuPasidCount)); set => WriteHere(nameof(MinIommuPasidCount), value); }

        public HalHvSystemPasidCapabilities(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalHvSystemPasidCapabilities>();
        }
    }
}