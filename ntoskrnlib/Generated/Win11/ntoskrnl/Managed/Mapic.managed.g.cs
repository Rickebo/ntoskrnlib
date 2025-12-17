using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MAPIC")]
    public sealed class Mapic : DynamicStructure
    {
        [Offset(0UL)]
        public DescriptionHeader Header { get => ReadStructure<DescriptionHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(36UL)]
        public uint LocalAPICAddress { get => ReadHere<uint>(nameof(LocalAPICAddress)); set => WriteHere(nameof(LocalAPICAddress), value); }

        [Offset(40UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(44UL)]
        [Length(1)]
        public DynamicArray APICTables { get => ReadStructure<DynamicArray>(nameof(APICTables)); set => WriteStructure(nameof(APICTables), value); }

        public Mapic(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Mapic>();
        }
    }
}