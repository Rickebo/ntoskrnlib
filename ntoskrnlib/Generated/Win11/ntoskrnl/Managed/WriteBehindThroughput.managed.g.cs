using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WRITE_BEHIND_THROUGHPUT")]
    public sealed class WriteBehindThroughput : DynamicStructure
    {
        [Offset(0UL)]
        public uint PagesYetToWrite { get => ReadHere<uint>(nameof(PagesYetToWrite)); set => WriteHere(nameof(PagesYetToWrite), value); }

        [Offset(4UL)]
        public uint Throughput { get => ReadHere<uint>(nameof(Throughput)); set => WriteHere(nameof(Throughput), value); }

        public WriteBehindThroughput(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WriteBehindThroughput>();
        }
    }
}