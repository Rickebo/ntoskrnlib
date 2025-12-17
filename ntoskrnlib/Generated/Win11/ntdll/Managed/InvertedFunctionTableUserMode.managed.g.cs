using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_INVERTED_FUNCTION_TABLE_USER_MODE")]
    public sealed class InvertedFunctionTableUserMode : DynamicStructure
    {
        [Offset(0UL)]
        public uint CurrentSize { get => ReadHere<uint>(nameof(CurrentSize)); set => WriteHere(nameof(CurrentSize), value); }

        [Offset(4UL)]
        public uint MaximumSize { get => ReadHere<uint>(nameof(MaximumSize)); set => WriteHere(nameof(MaximumSize), value); }

        [Offset(8UL)]
        public uint Epoch { get => ReadHere<uint>(nameof(Epoch)); set => WriteHere(nameof(Epoch), value); }

        [Offset(12UL)]
        public byte Overflow { get => ReadHere<byte>(nameof(Overflow)); set => WriteHere(nameof(Overflow), value); }

        [Offset(16UL)]
        [Length(512)]
        public DynamicArray TableEntry { get => ReadStructure<DynamicArray>(nameof(TableEntry)); set => WriteStructure(nameof(TableEntry), value); }

        public InvertedFunctionTableUserMode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InvertedFunctionTableUserMode>();
        }
    }
}