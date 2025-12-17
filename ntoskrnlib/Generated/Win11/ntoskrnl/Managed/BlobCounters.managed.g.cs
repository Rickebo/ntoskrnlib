using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BLOB_COUNTERS")]
    public sealed class BlobCounters : DynamicStructure
    {
        [Offset(0UL)]
        public uint CreatedObjects { get => ReadHere<uint>(nameof(CreatedObjects)); set => WriteHere(nameof(CreatedObjects), value); }

        [Offset(4UL)]
        public uint DeletedObjects { get => ReadHere<uint>(nameof(DeletedObjects)); set => WriteHere(nameof(DeletedObjects), value); }

        public BlobCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BlobCounters>();
        }
    }
}