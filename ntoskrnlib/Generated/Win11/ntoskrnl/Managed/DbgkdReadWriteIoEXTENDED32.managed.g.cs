using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_IO_EXTENDED32")]
    public sealed class DbgkdReadWriteIoEXTENDED32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint DataSize { get => ReadHere<uint>(nameof(DataSize)); set => WriteHere(nameof(DataSize), value); }

        [Offset(4UL)]
        public uint InterfaceType { get => ReadHere<uint>(nameof(InterfaceType)); set => WriteHere(nameof(InterfaceType), value); }

        [Offset(8UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(12UL)]
        public uint AddressSpace { get => ReadHere<uint>(nameof(AddressSpace)); set => WriteHere(nameof(AddressSpace), value); }

        [Offset(16UL)]
        public uint IoAddress { get => ReadHere<uint>(nameof(IoAddress)); set => WriteHere(nameof(IoAddress), value); }

        [Offset(20UL)]
        public uint DataValue { get => ReadHere<uint>(nameof(DataValue)); set => WriteHere(nameof(DataValue), value); }

        public DbgkdReadWriteIoEXTENDED32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdReadWriteIoEXTENDED32>();
        }
    }
}