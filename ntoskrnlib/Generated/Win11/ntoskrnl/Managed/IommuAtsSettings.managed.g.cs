using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_ATS_SETTINGS")]
    public sealed class IommuAtsSettings : DynamicStructure
    {
        [Offset(0UL)]
        public byte AtsSupported { get => ReadHere<byte>(nameof(AtsSupported)); set => WriteHere(nameof(AtsSupported), value); }

        [Offset(0UL)]
        public byte AtsRequired { get => ReadHere<byte>(nameof(AtsRequired)); set => WriteHere(nameof(AtsRequired), value); }

        [Offset(0UL)]
        public byte Rsvd { get => ReadHere<byte>(nameof(Rsvd)); set => WriteHere(nameof(Rsvd), value); }

        [Offset(0UL)]
        public byte AsUCHAR { get => ReadHere<byte>(nameof(AsUCHAR)); set => WriteHere(nameof(AsUCHAR), value); }

        public IommuAtsSettings(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuAtsSettings>();
        }
    }
}