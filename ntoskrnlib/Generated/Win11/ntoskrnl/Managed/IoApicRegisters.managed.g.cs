using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_APIC_REGISTERS")]
    public sealed class IoApicRegisters : DynamicStructure
    {
        [Offset(0UL)]
        public uint RegisterIndex { get => ReadHere<uint>(nameof(RegisterIndex)); set => WriteHere(nameof(RegisterIndex), value); }

        [Offset(4UL)]
        [Length(3)]
        public DynamicArray Reserved1 { get => ReadStructure<DynamicArray>(nameof(Reserved1)); set => WriteStructure(nameof(Reserved1), value); }

        [Offset(16UL)]
        public uint RegisterValue { get => ReadHere<uint>(nameof(RegisterValue)); set => WriteHere(nameof(RegisterValue), value); }

        [Offset(20UL)]
        [Length(11)]
        public DynamicArray Reserved2 { get => ReadStructure<DynamicArray>(nameof(Reserved2)); set => WriteStructure(nameof(Reserved2), value); }

        [Offset(64UL)]
        public uint EndOfInterrupt { get => ReadHere<uint>(nameof(EndOfInterrupt)); set => WriteHere(nameof(EndOfInterrupt), value); }

        public IoApicRegisters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoApicRegisters>();
        }
    }
}