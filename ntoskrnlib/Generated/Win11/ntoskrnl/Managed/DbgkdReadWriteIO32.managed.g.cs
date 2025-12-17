using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_IO32")]
    public sealed class DbgkdReadWriteIO32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint DataSize { get => ReadHere<uint>(nameof(DataSize)); set => WriteHere(nameof(DataSize), value); }

        [Offset(4UL)]
        public uint IoAddress { get => ReadHere<uint>(nameof(IoAddress)); set => WriteHere(nameof(IoAddress), value); }

        [Offset(8UL)]
        public uint DataValue { get => ReadHere<uint>(nameof(DataValue)); set => WriteHere(nameof(DataValue), value); }

        public DbgkdReadWriteIO32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdReadWriteIO32>();
        }
    }
}