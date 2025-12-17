using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_CONTEXT_EX")]
    public sealed class DbgkdContextEx : DynamicStructure
    {
        [Offset(0UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(4UL)]
        public uint ByteCount { get => ReadHere<uint>(nameof(ByteCount)); set => WriteHere(nameof(ByteCount), value); }

        [Offset(8UL)]
        public uint BytesCopied { get => ReadHere<uint>(nameof(BytesCopied)); set => WriteHere(nameof(BytesCopied), value); }

        public DbgkdContextEx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdContextEx>();
        }
    }
}