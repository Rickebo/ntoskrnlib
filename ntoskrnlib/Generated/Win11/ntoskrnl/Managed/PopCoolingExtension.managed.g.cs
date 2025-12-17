using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_COOLING_EXTENSION")]
    public sealed class PopCoolingExtension : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public ListEntry RequestListHead { get => ReadStructure<ListEntry>(nameof(RequestListHead)); set => WriteStructure(nameof(RequestListHead), value); }

        [Offset(32UL)]
        public PopRwLock Lock { get => ReadStructure<PopRwLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(48UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(56UL)]
        public IntPtr NotificationEntry { get => ReadHere<IntPtr>(nameof(NotificationEntry)); set => WriteHere(nameof(NotificationEntry), value); }

        [Offset(64UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(65UL)]
        public byte ActiveEngaged { get => ReadHere<byte>(nameof(ActiveEngaged)); set => WriteHere(nameof(ActiveEngaged), value); }

        [Offset(66UL)]
        public byte ThrottleLimit { get => ReadHere<byte>(nameof(ThrottleLimit)); set => WriteHere(nameof(ThrottleLimit), value); }

        [Offset(67UL)]
        public byte UpdatingToCurrent { get => ReadHere<byte>(nameof(UpdatingToCurrent)); set => WriteHere(nameof(UpdatingToCurrent), value); }

        [Offset(72UL)]
        public IntPtr RemovalFlushEvent { get => ReadHere<IntPtr>(nameof(RemovalFlushEvent)); set => WriteHere(nameof(RemovalFlushEvent), value); }

        [Offset(80UL)]
        public IntPtr PnpFlushEvent { get => ReadHere<IntPtr>(nameof(PnpFlushEvent)); set => WriteHere(nameof(PnpFlushEvent), value); }

        [Offset(88UL)]
        public ThermalCoolingInterface Interface { get => ReadStructure<ThermalCoolingInterface>(nameof(Interface)); set => WriteStructure(nameof(Interface), value); }

        public PopCoolingExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopCoolingExtension>();
        }
    }
}