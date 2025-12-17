using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_MSR")]
    public sealed class DbgkdReadWriteMsr : DynamicStructure
    {
        [Offset(0UL)]
        public uint Msr { get => ReadHere<uint>(nameof(Msr)); set => WriteHere(nameof(Msr), value); }

        [Offset(4UL)]
        public uint DataValueLow { get => ReadHere<uint>(nameof(DataValueLow)); set => WriteHere(nameof(DataValueLow), value); }

        [Offset(8UL)]
        public uint DataValueHigh { get => ReadHere<uint>(nameof(DataValueHigh)); set => WriteHere(nameof(DataValueHigh), value); }

        public DbgkdReadWriteMsr(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdReadWriteMsr>();
        }
    }
}