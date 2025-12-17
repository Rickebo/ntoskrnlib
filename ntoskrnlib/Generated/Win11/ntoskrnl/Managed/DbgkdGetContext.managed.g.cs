using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_CONTEXT")]
    public sealed class DbgkdGetContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint Unused { get => ReadHere<uint>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        public DbgkdGetContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdGetContext>();
        }
    }
}