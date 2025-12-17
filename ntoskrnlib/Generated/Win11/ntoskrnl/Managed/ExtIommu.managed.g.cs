using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU")]
    public sealed class ExtIommu : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(8UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(16UL)]
        public ExtIommuCapabilities Capabilities { get => ReadStructure<ExtIommuCapabilities>(nameof(Capabilities)); set => WriteStructure(nameof(Capabilities), value); }

        [Offset(24UL)]
        public uint MaxOutputAddressWidth { get => ReadHere<uint>(nameof(MaxOutputAddressWidth)); set => WriteHere(nameof(MaxOutputAddressWidth), value); }

        [Offset(28UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(30UL)]
        public ushort PciSegmentNumber { get => ReadHere<ushort>(nameof(PciSegmentNumber)); set => WriteHere(nameof(PciSegmentNumber), value); }

        [Offset(32UL)]
        public ExtIommuFunctionTable FunctionTable { get => ReadStructure<ExtIommuFunctionTable>(nameof(FunctionTable)); set => WriteStructure(nameof(FunctionTable), value); }

        public ExtIommu(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommu>();
        }
    }
}