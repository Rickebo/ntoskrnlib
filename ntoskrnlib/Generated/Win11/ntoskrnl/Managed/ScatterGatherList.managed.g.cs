using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SCATTER_GATHER_LIST")]
    public sealed class ScatterGatherList : DynamicStructure
    {
        [Offset(0UL)]
        public uint NumberOfElements { get => ReadHere<uint>(nameof(NumberOfElements)); set => WriteHere(nameof(NumberOfElements), value); }

        [Offset(8UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(16UL)]
        [Length(0)]
        public DynamicArray Elements { get => ReadStructure<DynamicArray>(nameof(Elements)); set => WriteStructure(nameof(Elements), value); }

        public ScatterGatherList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ScatterGatherList>();
        }
    }
}