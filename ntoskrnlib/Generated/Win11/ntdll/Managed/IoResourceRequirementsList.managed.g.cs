using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IO_RESOURCE_REQUIREMENTS_LIST")]
    public sealed class IoResourceRequirementsList : DynamicStructure
    {
        [Offset(0UL)]
        public uint ListSize { get => ReadHere<uint>(nameof(ListSize)); set => WriteHere(nameof(ListSize), value); }

        [Offset(4UL)]
        public uint InterfaceType { get => ReadHere<uint>(nameof(InterfaceType)); set => WriteHere(nameof(InterfaceType), value); }

        [Offset(8UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(12UL)]
        public uint SlotNumber { get => ReadHere<uint>(nameof(SlotNumber)); set => WriteHere(nameof(SlotNumber), value); }

        [Offset(16UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(28UL)]
        public uint AlternativeLists { get => ReadHere<uint>(nameof(AlternativeLists)); set => WriteHere(nameof(AlternativeLists), value); }

        [Offset(32UL)]
        [Length(1)]
        public DynamicArray List { get => ReadStructure<DynamicArray>(nameof(List)); set => WriteStructure(nameof(List), value); }

        public IoResourceRequirementsList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoResourceRequirementsList>();
        }
    }
}