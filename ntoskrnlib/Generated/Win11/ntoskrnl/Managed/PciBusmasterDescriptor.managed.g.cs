using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCI_BUSMASTER_DESCRIPTOR")]
    public sealed class PciBusmasterDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint Segment { get => ReadHere<uint>(nameof(Segment)); set => WriteHere(nameof(Segment), value); }

        [Offset(8UL)]
        public UnnamedTag DeviceRid { get => ReadStructure<UnnamedTag>(nameof(DeviceRid)); set => WriteStructure(nameof(DeviceRid), value); }

        [Offset(8UL)]
        public UnnamedTag BridgeRid { get => ReadStructure<UnnamedTag>(nameof(BridgeRid)); set => WriteStructure(nameof(BridgeRid), value); }

        [Offset(8UL)]
        public UnnamedTag MultipleBridges { get => ReadStructure<UnnamedTag>(nameof(MultipleBridges)); set => WriteStructure(nameof(MultipleBridges), value); }

        public PciBusmasterDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PciBusmasterDescriptor>();
        }
    }
}