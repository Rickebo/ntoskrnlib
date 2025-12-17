using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_MEMORY64")]
    public sealed class DbgkdReadMEMORY64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TargetBaseAddress { get => ReadHere<ulong>(nameof(TargetBaseAddress)); set => WriteHere(nameof(TargetBaseAddress), value); }

        [Offset(8UL)]
        public uint TransferCount { get => ReadHere<uint>(nameof(TransferCount)); set => WriteHere(nameof(TransferCount), value); }

        [Offset(12UL)]
        public uint ActualBytesRead { get => ReadHere<uint>(nameof(ActualBytesRead)); set => WriteHere(nameof(ActualBytesRead), value); }

        public DbgkdReadMEMORY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdReadMEMORY64>();
        }
    }
}