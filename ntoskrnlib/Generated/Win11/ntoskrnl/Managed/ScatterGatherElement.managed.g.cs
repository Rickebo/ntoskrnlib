using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SCATTER_GATHER_ELEMENT")]
    public sealed class ScatterGatherElement : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger Address { get => ReadStructure<LargeInteger>(nameof(Address)); set => WriteStructure(nameof(Address), value); }

        [Offset(8UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(16UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ScatterGatherElement(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ScatterGatherElement>();
        }
    }
}