using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID_FLAGS")]
    public sealed class ExtIommuDeviceIdFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ushort AsUSHORT { get => ReadHere<ushort>(nameof(AsUSHORT)); set => WriteHere(nameof(AsUSHORT), value); }

        [Offset(0UL)]
        public ushort IsAliased { get => ReadHere<ushort>(nameof(IsAliased)); set => WriteHere(nameof(IsAliased), value); }

        [Offset(0UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ExtIommuDeviceIdFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuDeviceIdFlags>();
        }
    }
}