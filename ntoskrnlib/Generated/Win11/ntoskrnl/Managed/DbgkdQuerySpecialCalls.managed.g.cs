using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_QUERY_SPECIAL_CALLS")]
    public sealed class DbgkdQuerySpecialCalls : DynamicStructure
    {
        [Offset(0UL)]
        public uint NumberOfSpecialCalls { get => ReadHere<uint>(nameof(NumberOfSpecialCalls)); set => WriteHere(nameof(NumberOfSpecialCalls), value); }

        public DbgkdQuerySpecialCalls(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdQuerySpecialCalls>();
        }
    }
}