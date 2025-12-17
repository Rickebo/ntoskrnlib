using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXP_PULLED_FILE_TABLE")]
    public sealed class ExpPulledFileTable : DynamicStructure
    {
        [Offset(0UL)]
        public int NumberOfFiles { get => ReadHere<int>(nameof(NumberOfFiles)); set => WriteHere(nameof(NumberOfFiles), value); }

        [Offset(4UL)]
        public int TableSize { get => ReadHere<int>(nameof(TableSize)); set => WriteHere(nameof(TableSize), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Hashes { get => ReadStructure<DynamicArray>(nameof(Hashes)); set => WriteStructure(nameof(Hashes), value); }

        public ExpPulledFileTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExpPulledFileTable>();
        }
    }
}