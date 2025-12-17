using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_DEVICE_NOTIFY_ORDER")]
    public sealed class PoDeviceNotifyOrder : DynamicStructure
    {
        [Offset(0UL)]
        public byte Locked { get => ReadHere<byte>(nameof(Locked)); set => WriteHere(nameof(Locked), value); }

        [Offset(8UL)]
        public IntPtr WarmEjectPdoPointer { get => ReadHere<IntPtr>(nameof(WarmEjectPdoPointer)); set => WriteHere(nameof(WarmEjectPdoPointer), value); }

        [Offset(16UL)]
        [Length(5)]
        public DynamicArray OrderLevel { get => ReadStructure<DynamicArray>(nameof(OrderLevel)); set => WriteStructure(nameof(OrderLevel), value); }

        [Offset(376UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public PoDeviceNotifyOrder(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoDeviceNotifyOrder>();
        }
    }
}