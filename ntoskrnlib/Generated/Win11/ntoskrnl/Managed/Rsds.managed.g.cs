using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RSDS")]
    public sealed class Rsds : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public Guid Guid { get => ReadStructure<Guid>(nameof(Guid)); set => WriteStructure(nameof(Guid), value); }

        [Offset(20UL)]
        public uint Age { get => ReadHere<uint>(nameof(Age)); set => WriteHere(nameof(Age), value); }

        [Offset(24UL)]
        [Length(1)]
        public DynamicArray PdbName { get => ReadStructure<DynamicArray>(nameof(PdbName)); set => WriteStructure(nameof(PdbName), value); }

        public Rsds(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Rsds>();
        }
    }
}