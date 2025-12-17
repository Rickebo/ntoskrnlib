using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_REALTIME_CONSUMER")]
    public sealed class EtwRealtimeConsumer : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(16UL)]
        public IntPtr ProcessHandle { get => ReadHere<IntPtr>(nameof(ProcessHandle)); set => WriteHere(nameof(ProcessHandle), value); }

        [Offset(24UL)]
        public IntPtr ProcessObject { get => ReadHere<IntPtr>(nameof(ProcessObject)); set => WriteHere(nameof(ProcessObject), value); }

        [Offset(32UL)]
        public IntPtr NextNotDelivered { get => ReadHere<IntPtr>(nameof(NextNotDelivered)); set => WriteHere(nameof(NextNotDelivered), value); }

        [Offset(40UL)]
        public IntPtr RealtimeConnectContext { get => ReadHere<IntPtr>(nameof(RealtimeConnectContext)); set => WriteHere(nameof(RealtimeConnectContext), value); }

        [Offset(48UL)]
        public IntPtr DisconnectEvent { get => ReadHere<IntPtr>(nameof(DisconnectEvent)); set => WriteHere(nameof(DisconnectEvent), value); }

        [Offset(56UL)]
        public IntPtr DataAvailableEvent { get => ReadHere<IntPtr>(nameof(DataAvailableEvent)); set => WriteHere(nameof(DataAvailableEvent), value); }

        [Offset(64UL)]
        public IntPtr UserBufferCount { get => ReadHere<IntPtr>(nameof(UserBufferCount)); set => WriteHere(nameof(UserBufferCount), value); }

        [Offset(72UL)]
        public IntPtr UserBufferListHead { get => ReadHere<IntPtr>(nameof(UserBufferListHead)); set => WriteHere(nameof(UserBufferListHead), value); }

        [Offset(80UL)]
        public uint BuffersLost { get => ReadHere<uint>(nameof(BuffersLost)); set => WriteHere(nameof(BuffersLost), value); }

        [Offset(84UL)]
        public uint EmptyBuffersCount { get => ReadHere<uint>(nameof(EmptyBuffersCount)); set => WriteHere(nameof(EmptyBuffersCount), value); }

        [Offset(88UL)]
        public ushort LoggerId { get => ReadHere<ushort>(nameof(LoggerId)); set => WriteHere(nameof(LoggerId), value); }

        [Offset(90UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(90UL)]
        public byte ShutDownRequested { get => ReadHere<byte>(nameof(ShutDownRequested)); set => WriteHere(nameof(ShutDownRequested), value); }

        [Offset(90UL)]
        public byte NewBuffersLost { get => ReadHere<byte>(nameof(NewBuffersLost)); set => WriteHere(nameof(NewBuffersLost), value); }

        [Offset(90UL)]
        public byte Disconnected { get => ReadHere<byte>(nameof(Disconnected)); set => WriteHere(nameof(Disconnected), value); }

        [Offset(90UL)]
        public byte Notified { get => ReadHere<byte>(nameof(Notified)); set => WriteHere(nameof(Notified), value); }

        [Offset(90UL)]
        public byte Wow { get => ReadHere<byte>(nameof(Wow)); set => WriteHere(nameof(Wow), value); }

        [Offset(96UL)]
        public RtlBitmap ReservedBufferSpaceBitMap { get => ReadStructure<RtlBitmap>(nameof(ReservedBufferSpaceBitMap)); set => WriteStructure(nameof(ReservedBufferSpaceBitMap), value); }

        [Offset(112UL)]
        public IntPtr ReservedBufferSpace { get => ReadHere<IntPtr>(nameof(ReservedBufferSpace)); set => WriteHere(nameof(ReservedBufferSpace), value); }

        [Offset(120UL)]
        public uint ReservedBufferSpaceSize { get => ReadHere<uint>(nameof(ReservedBufferSpaceSize)); set => WriteHere(nameof(ReservedBufferSpaceSize), value); }

        [Offset(124UL)]
        public uint UserPagesAllocated { get => ReadHere<uint>(nameof(UserPagesAllocated)); set => WriteHere(nameof(UserPagesAllocated), value); }

        [Offset(128UL)]
        public uint UserPagesReused { get => ReadHere<uint>(nameof(UserPagesReused)); set => WriteHere(nameof(UserPagesReused), value); }

        [Offset(136UL)]
        public IntPtr EventsLostCount { get => ReadHere<IntPtr>(nameof(EventsLostCount)); set => WriteHere(nameof(EventsLostCount), value); }

        [Offset(144UL)]
        public IntPtr BuffersLostCount { get => ReadHere<IntPtr>(nameof(BuffersLostCount)); set => WriteHere(nameof(BuffersLostCount), value); }

        [Offset(152UL)]
        public IntPtr SiloState { get => ReadHere<IntPtr>(nameof(SiloState)); set => WriteHere(nameof(SiloState), value); }

        public EtwRealtimeConsumer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwRealtimeConsumer>();
        }
    }
}