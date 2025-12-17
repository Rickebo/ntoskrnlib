using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_COMPOSITEFS_LAYER_INFORMATION")]
    public sealed class CompositefsLayerInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint DeviceType { get => ReadHere<uint>(nameof(DeviceType)); set => WriteHere(nameof(DeviceType), value); }

        [Offset(8UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public CompositefsLayerInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CompositefsLayerInformation>();
        }
    }
}