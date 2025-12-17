using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_CONTEXT")]
    public sealed class DbgkdSetContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint ContextFlags { get => ReadHere<uint>(nameof(ContextFlags)); set => WriteHere(nameof(ContextFlags), value); }

        public DbgkdSetContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdSetContext>();
        }
    }
}