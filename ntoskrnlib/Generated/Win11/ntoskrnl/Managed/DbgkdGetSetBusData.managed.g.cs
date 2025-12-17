using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_SET_BUS_DATA")]
    public sealed class DbgkdGetSetBusData : DynamicStructure
    {
        [Offset(0UL)]
        public uint BusDataType { get => ReadHere<uint>(nameof(BusDataType)); set => WriteHere(nameof(BusDataType), value); }

        [Offset(4UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(8UL)]
        public uint SlotNumber { get => ReadHere<uint>(nameof(SlotNumber)); set => WriteHere(nameof(SlotNumber), value); }

        [Offset(12UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(16UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        public DbgkdGetSetBusData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdGetSetBusData>();
        }
    }
}