using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_NOTIFY_ORDER_LEVEL")]
    public sealed class PoNotifyOrderLevel : DynamicStructure
    {
        [Offset(0UL)]
        public uint DeviceCount { get => ReadHere<uint>(nameof(DeviceCount)); set => WriteHere(nameof(DeviceCount), value); }

        [Offset(4UL)]
        public uint ActiveCount { get => ReadHere<uint>(nameof(ActiveCount)); set => WriteHere(nameof(ActiveCount), value); }

        [Offset(8UL)]
        public ListEntry WaitSleep { get => ReadStructure<ListEntry>(nameof(WaitSleep)); set => WriteStructure(nameof(WaitSleep), value); }

        [Offset(24UL)]
        public ListEntry ReadySleep { get => ReadStructure<ListEntry>(nameof(ReadySleep)); set => WriteStructure(nameof(ReadySleep), value); }

        [Offset(40UL)]
        public ListEntry ReadyS0 { get => ReadStructure<ListEntry>(nameof(ReadyS0)); set => WriteStructure(nameof(ReadyS0), value); }

        [Offset(56UL)]
        public ListEntry WaitS0 { get => ReadStructure<ListEntry>(nameof(WaitS0)); set => WriteStructure(nameof(WaitS0), value); }

        public PoNotifyOrderLevel(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoNotifyOrderLevel>();
        }
    }
}