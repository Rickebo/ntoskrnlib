using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_WRITE_MEMORY64")]
    public sealed class DbgkdWriteMEMORY64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TargetBaseAddress { get => ReadHere<ulong>(nameof(TargetBaseAddress)); set => WriteHere(nameof(TargetBaseAddress), value); }

        [Offset(8UL)]
        public uint TransferCount { get => ReadHere<uint>(nameof(TransferCount)); set => WriteHere(nameof(TransferCount), value); }

        [Offset(12UL)]
        public uint ActualBytesWritten { get => ReadHere<uint>(nameof(ActualBytesWritten)); set => WriteHere(nameof(ActualBytesWritten), value); }

        public DbgkdWriteMEMORY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdWriteMEMORY64>();
        }
    }
}