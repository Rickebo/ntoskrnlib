using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_POWER_LIMIT_EXTENSION")]
    public sealed class PopPowerLimitExtension : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public ListEntry RequestListHead { get => ReadStructure<ListEntry>(nameof(RequestListHead)); set => WriteStructure(nameof(RequestListHead), value); }

        [Offset(32UL)]
        public PopRwLock Lock { get => ReadStructure<PopRwLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(48UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(56UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(64UL)]
        public IntPtr NotificationEntry { get => ReadHere<IntPtr>(nameof(NotificationEntry)); set => WriteHere(nameof(NotificationEntry), value); }

        [Offset(72UL)]
        public uint LimitCount { get => ReadHere<uint>(nameof(LimitCount)); set => WriteHere(nameof(LimitCount), value); }

        [Offset(80UL)]
        public IntPtr LimitAttributes { get => ReadHere<IntPtr>(nameof(LimitAttributes)); set => WriteHere(nameof(LimitAttributes), value); }

        [Offset(88UL)]
        public IntPtr LimitValues { get => ReadHere<IntPtr>(nameof(LimitValues)); set => WriteHere(nameof(LimitValues), value); }

        [Offset(96UL)]
        public uint UpdateMaskCount { get => ReadHere<uint>(nameof(UpdateMaskCount)); set => WriteHere(nameof(UpdateMaskCount), value); }

        [Offset(104UL)]
        public IntPtr UpdateMask { get => ReadHere<IntPtr>(nameof(UpdateMask)); set => WriteHere(nameof(UpdateMask), value); }

        [Offset(112UL)]
        public PowerLimitInterface Interface { get => ReadStructure<PowerLimitInterface>(nameof(Interface)); set => WriteStructure(nameof(Interface), value); }

        [Offset(176UL)]
        public uint PendingSetCount { get => ReadHere<uint>(nameof(PendingSetCount)); set => WriteHere(nameof(PendingSetCount), value); }

        [Offset(180UL)]
        public uint PendingQueryCount { get => ReadHere<uint>(nameof(PendingQueryCount)); set => WriteHere(nameof(PendingQueryCount), value); }

        [Offset(184UL)]
        public IntPtr RemovalFlushEvent { get => ReadHere<IntPtr>(nameof(RemovalFlushEvent)); set => WriteHere(nameof(RemovalFlushEvent), value); }

        [Offset(192UL)]
        public IntPtr PnpFlushEvent { get => ReadHere<IntPtr>(nameof(PnpFlushEvent)); set => WriteHere(nameof(PnpFlushEvent), value); }

        public PopPowerLimitExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopPowerLimitExtension>();
        }
    }
}