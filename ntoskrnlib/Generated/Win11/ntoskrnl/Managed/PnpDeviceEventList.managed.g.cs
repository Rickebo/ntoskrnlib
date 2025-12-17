using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_EVENT_LIST")]
    public sealed class PnpDeviceEventList : DynamicStructure
    {
        [Offset(0UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(8UL)]
        public Kmutant EventQueueMutex { get => ReadStructure<Kmutant>(nameof(EventQueueMutex)); set => WriteStructure(nameof(EventQueueMutex), value); }

        [Offset(64UL)]
        public FastMutex Lock { get => ReadStructure<FastMutex>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(120UL)]
        public ListEntry List { get => ReadStructure<ListEntry>(nameof(List)); set => WriteStructure(nameof(List), value); }

        public PnpDeviceEventList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpDeviceEventList>();
        }
    }
}