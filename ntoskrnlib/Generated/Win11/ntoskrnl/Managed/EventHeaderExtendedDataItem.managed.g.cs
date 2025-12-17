using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EVENT_HEADER_EXTENDED_DATA_ITEM")]
    public sealed class EventHeaderExtendedDataItem : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Reserved1 { get => ReadHere<ushort>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(2UL)]
        public ushort ExtType { get => ReadHere<ushort>(nameof(ExtType)); set => WriteHere(nameof(ExtType), value); }

        [Offset(4UL)]
        public ushort Linkage { get => ReadHere<ushort>(nameof(Linkage)); set => WriteHere(nameof(Linkage), value); }

        [Offset(4UL)]
        public ushort Reserved2 { get => ReadHere<ushort>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(6UL)]
        public ushort DataSize { get => ReadHere<ushort>(nameof(DataSize)); set => WriteHere(nameof(DataSize), value); }

        [Offset(8UL)]
        public ulong DataPtr { get => ReadHere<ulong>(nameof(DataPtr)); set => WriteHere(nameof(DataPtr), value); }

        public EventHeaderExtendedDataItem(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventHeaderExtendedDataItem>();
        }
    }
}