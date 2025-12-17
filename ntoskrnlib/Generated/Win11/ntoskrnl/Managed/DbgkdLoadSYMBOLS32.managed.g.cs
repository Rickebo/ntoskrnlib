using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_LOAD_SYMBOLS32")]
    public sealed class DbgkdLoadSYMBOLS32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint PathNameLength { get => ReadHere<uint>(nameof(PathNameLength)); set => WriteHere(nameof(PathNameLength), value); }

        [Offset(4UL)]
        public uint BaseOfDll { get => ReadHere<uint>(nameof(BaseOfDll)); set => WriteHere(nameof(BaseOfDll), value); }

        [Offset(8UL)]
        public uint ProcessId { get => ReadHere<uint>(nameof(ProcessId)); set => WriteHere(nameof(ProcessId), value); }

        [Offset(12UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        [Offset(16UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(20UL)]
        public byte UnloadSymbols { get => ReadHere<byte>(nameof(UnloadSymbols)); set => WriteHere(nameof(UnloadSymbols), value); }

        public DbgkdLoadSYMBOLS32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdLoadSYMBOLS32>();
        }
    }
}