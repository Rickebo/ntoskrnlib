using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_QUERY_MEMORY")]
    public sealed class DbgkdQueryMemory : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Address { get => ReadHere<ulong>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(8UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(16UL)]
        public uint AddressSpace { get => ReadHere<uint>(nameof(AddressSpace)); set => WriteHere(nameof(AddressSpace), value); }

        [Offset(20UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public DbgkdQueryMemory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdQueryMemory>();
        }
    }
}