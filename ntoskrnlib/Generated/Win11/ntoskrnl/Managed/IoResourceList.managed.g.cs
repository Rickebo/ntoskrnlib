using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_RESOURCE_LIST")]
    public sealed class IoResourceList : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(2UL)]
        public ushort Revision { get => ReadHere<ushort>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(4UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Descriptors { get => ReadStructure<DynamicArray>(nameof(Descriptors)); set => WriteStructure(nameof(Descriptors), value); }

        public IoResourceList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoResourceList>();
        }
    }
}