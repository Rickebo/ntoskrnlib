using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_MEMORY32")]
    public sealed class DbgkdReadMEMORY32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint TargetBaseAddress { get => ReadHere<uint>(nameof(TargetBaseAddress)); set => WriteHere(nameof(TargetBaseAddress), value); }

        [Offset(4UL)]
        public uint TransferCount { get => ReadHere<uint>(nameof(TransferCount)); set => WriteHere(nameof(TransferCount), value); }

        [Offset(8UL)]
        public uint ActualBytesRead { get => ReadHere<uint>(nameof(ActualBytesRead)); set => WriteHere(nameof(ActualBytesRead), value); }

        public DbgkdReadMEMORY32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdReadMEMORY32>();
        }
    }
}