using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION")]
    public sealed class DmaCommonBufferExtendedConfiguration : DynamicStructure
    {
        [Offset(0UL)]
        public uint ConfigType { get => ReadHere<uint>(nameof(ConfigType)); set => WriteHere(nameof(ConfigType), value); }

        [Offset(8UL)]
        public UnnamedTag LogicalAddressLimits { get => ReadStructure<UnnamedTag>(nameof(LogicalAddressLimits)); set => WriteStructure(nameof(LogicalAddressLimits), value); }

        [Offset(8UL)]
        public UnnamedTag SubSection { get => ReadStructure<UnnamedTag>(nameof(SubSection)); set => WriteStructure(nameof(SubSection), value); }

        [Offset(8UL)]
        public uint HardwareAccessType { get => ReadHere<uint>(nameof(HardwareAccessType)); set => WriteHere(nameof(HardwareAccessType), value); }

        [Offset(8UL)]
        [Length(4)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public DmaCommonBufferExtendedConfiguration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaCommonBufferExtendedConfiguration>();
        }
    }
}