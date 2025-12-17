using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_IO64")]
    public sealed class DbgkdReadWriteIO64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong IoAddress { get => ReadHere<ulong>(nameof(IoAddress)); set => WriteHere(nameof(IoAddress), value); }

        [Offset(8UL)]
        public uint DataSize { get => ReadHere<uint>(nameof(DataSize)); set => WriteHere(nameof(DataSize), value); }

        [Offset(12UL)]
        public uint DataValue { get => ReadHere<uint>(nameof(DataValue)); set => WriteHere(nameof(DataValue), value); }

        public DbgkdReadWriteIO64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdReadWriteIO64>();
        }
    }
}