using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ACPI_METHOD_ARGUMENT_V1")]
    public sealed class AcpiMethodArgumentV1 : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public ushort DataLength { get => ReadHere<ushort>(nameof(DataLength)); set => WriteHere(nameof(DataLength), value); }

        [Offset(4UL)]
        public uint Argument { get => ReadHere<uint>(nameof(Argument)); set => WriteHere(nameof(Argument), value); }

        [Offset(4UL)]
        [Length(1)]
        public DynamicArray Data { get => ReadStructure<DynamicArray>(nameof(Data)); set => WriteStructure(nameof(Data), value); }

        public AcpiMethodArgumentV1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AcpiMethodArgumentV1>();
        }
    }
}