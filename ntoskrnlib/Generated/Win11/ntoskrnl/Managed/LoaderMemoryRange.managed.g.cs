using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_MEMORY_RANGE")]
    public sealed class LoaderMemoryRange : DynamicStructure
    {
        [Offset(0UL)]
        public ulong StartPage { get => ReadHere<ulong>(nameof(StartPage)); set => WriteHere(nameof(StartPage), value); }

        [Offset(8UL)]
        public ulong NumberOfPages { get => ReadHere<ulong>(nameof(NumberOfPages)); set => WriteHere(nameof(NumberOfPages), value); }

        public LoaderMemoryRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderMemoryRange>();
        }
    }
}