using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VACB_ARRAY_HEADER")]
    public sealed class VacbArrayHeader : DynamicStructure
    {
        [Offset(0UL)]
        public uint VacbArrayIndex { get => ReadHere<uint>(nameof(VacbArrayIndex)); set => WriteHere(nameof(VacbArrayIndex), value); }

        [Offset(4UL)]
        public uint MappingCount { get => ReadHere<uint>(nameof(MappingCount)); set => WriteHere(nameof(MappingCount), value); }

        [Offset(8UL)]
        public uint HighestMappedIndex { get => ReadHere<uint>(nameof(HighestMappedIndex)); set => WriteHere(nameof(HighestMappedIndex), value); }

        [Offset(12UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public VacbArrayHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VacbArrayHeader>();
        }
    }
}