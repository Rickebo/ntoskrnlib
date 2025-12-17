using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KDEVICE_QUEUE_ENTRY")]
    public sealed class KdeviceQueueEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry DeviceListEntry { get => ReadStructure<ListEntry>(nameof(DeviceListEntry)); set => WriteStructure(nameof(DeviceListEntry), value); }

        [Offset(16UL)]
        public uint SortKey { get => ReadHere<uint>(nameof(SortKey)); set => WriteHere(nameof(SortKey), value); }

        [Offset(20UL)]
        public byte Inserted { get => ReadHere<byte>(nameof(Inserted)); set => WriteHere(nameof(Inserted), value); }

        public KdeviceQueueEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KdeviceQueueEntry>();
        }
    }
}