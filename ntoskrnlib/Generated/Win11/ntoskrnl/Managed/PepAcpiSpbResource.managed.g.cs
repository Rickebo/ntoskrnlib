using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_ACPI_SPB_RESOURCE")]
    public sealed class PepAcpiSpbResource : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public PepAcpiResourceFlags Flags { get => ReadStructure<PepAcpiResourceFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public ushort TypeSpecificFlags { get => ReadHere<ushort>(nameof(TypeSpecificFlags)); set => WriteHere(nameof(TypeSpecificFlags), value); }

        [Offset(10UL)]
        public byte ResourceSourceIndex { get => ReadHere<byte>(nameof(ResourceSourceIndex)); set => WriteHere(nameof(ResourceSourceIndex), value); }

        [Offset(16UL)]
        public IntPtr ResourceSourceName { get => ReadHere<IntPtr>(nameof(ResourceSourceName)); set => WriteHere(nameof(ResourceSourceName), value); }

        [Offset(24UL)]
        public IntPtr VendorData { get => ReadHere<IntPtr>(nameof(VendorData)); set => WriteHere(nameof(VendorData), value); }

        [Offset(32UL)]
        public ushort VendorDataLength { get => ReadHere<ushort>(nameof(VendorDataLength)); set => WriteHere(nameof(VendorDataLength), value); }

        public PepAcpiSpbResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepAcpiSpbResource>();
        }
    }
}