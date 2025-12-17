using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INVERTED_FUNCTION_TABLE_ENTRY")]
    public sealed class InvertedFunctionTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr FunctionTable { get => ReadHere<IntPtr>(nameof(FunctionTable)); set => WriteHere(nameof(FunctionTable), value); }

        [Offset(0UL)]
        public IntPtr DynamicTable { get => ReadHere<IntPtr>(nameof(DynamicTable)); set => WriteHere(nameof(DynamicTable), value); }

        [Offset(8UL)]
        public IntPtr ImageBase { get => ReadHere<IntPtr>(nameof(ImageBase)); set => WriteHere(nameof(ImageBase), value); }

        [Offset(16UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(20UL)]
        public uint SizeOfTable { get => ReadHere<uint>(nameof(SizeOfTable)); set => WriteHere(nameof(SizeOfTable), value); }

        public InvertedFunctionTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InvertedFunctionTableEntry>();
        }
    }
}