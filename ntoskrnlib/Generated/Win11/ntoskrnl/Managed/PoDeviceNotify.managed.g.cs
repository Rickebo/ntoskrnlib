using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_DEVICE_NOTIFY")]
    public sealed class PoDeviceNotify : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public ListEntry PowerChildren { get => ReadStructure<ListEntry>(nameof(PowerChildren)); set => WriteStructure(nameof(PowerChildren), value); }

        [Offset(32UL)]
        public ListEntry PowerParents { get => ReadStructure<ListEntry>(nameof(PowerParents)); set => WriteStructure(nameof(PowerParents), value); }

        [Offset(48UL)]
        public IntPtr TargetDevice { get => ReadHere<IntPtr>(nameof(TargetDevice)); set => WriteHere(nameof(TargetDevice), value); }

        [Offset(56UL)]
        public byte OrderLevel { get => ReadHere<byte>(nameof(OrderLevel)); set => WriteHere(nameof(OrderLevel), value); }

        [Offset(64UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(72UL)]
        public IntPtr DeviceName { get => ReadHere<IntPtr>(nameof(DeviceName)); set => WriteHere(nameof(DeviceName), value); }

        [Offset(80UL)]
        public IntPtr DriverName { get => ReadHere<IntPtr>(nameof(DriverName)); set => WriteHere(nameof(DriverName), value); }

        [Offset(88UL)]
        public uint ChildCount { get => ReadHere<uint>(nameof(ChildCount)); set => WriteHere(nameof(ChildCount), value); }

        [Offset(92UL)]
        public uint ActiveChild { get => ReadHere<uint>(nameof(ActiveChild)); set => WriteHere(nameof(ActiveChild), value); }

        [Offset(96UL)]
        public uint ParentCount { get => ReadHere<uint>(nameof(ParentCount)); set => WriteHere(nameof(ParentCount), value); }

        [Offset(100UL)]
        public uint ActiveParent { get => ReadHere<uint>(nameof(ActiveParent)); set => WriteHere(nameof(ActiveParent), value); }

        public PoDeviceNotify(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoDeviceNotify>();
        }
    }
}