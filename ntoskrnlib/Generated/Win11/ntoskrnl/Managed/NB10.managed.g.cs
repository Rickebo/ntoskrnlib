using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NB10")]
    public sealed class NB10 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(8UL)]
        public uint TimeStamp { get => ReadHere<uint>(nameof(TimeStamp)); set => WriteHere(nameof(TimeStamp), value); }

        [Offset(12UL)]
        public uint Age { get => ReadHere<uint>(nameof(Age)); set => WriteHere(nameof(Age), value); }

        [Offset(16UL)]
        [Length(1)]
        public DynamicArray PdbName { get => ReadStructure<DynamicArray>(nameof(PdbName)); set => WriteStructure(nameof(PdbName), value); }

        public NB10(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NB10>();
        }
    }
}