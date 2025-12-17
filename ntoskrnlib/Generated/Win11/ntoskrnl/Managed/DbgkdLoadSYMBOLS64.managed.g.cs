using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_LOAD_SYMBOLS64")]
    public sealed class DbgkdLoadSYMBOLS64 : DynamicStructure
    {
        [Offset(0UL)]
        public uint PathNameLength { get => ReadHere<uint>(nameof(PathNameLength)); set => WriteHere(nameof(PathNameLength), value); }

        [Offset(8UL)]
        public ulong BaseOfDll { get => ReadHere<ulong>(nameof(BaseOfDll)); set => WriteHere(nameof(BaseOfDll), value); }

        [Offset(16UL)]
        public ulong ProcessId { get => ReadHere<ulong>(nameof(ProcessId)); set => WriteHere(nameof(ProcessId), value); }

        [Offset(24UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        [Offset(28UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(32UL)]
        public byte UnloadSymbols { get => ReadHere<byte>(nameof(UnloadSymbols)); set => WriteHere(nameof(UnloadSymbols), value); }

        public DbgkdLoadSYMBOLS64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdLoadSYMBOLS64>();
        }
    }
}