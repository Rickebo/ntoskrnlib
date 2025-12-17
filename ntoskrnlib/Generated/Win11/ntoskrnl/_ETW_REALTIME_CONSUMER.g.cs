#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _ETW_REALTIME_CONSUMER
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public IntPtr ProcessHandle;
        [FieldOffset(24)]
        public IntPtr ProcessObject;
        [FieldOffset(32)]
        public IntPtr NextNotDelivered;
        [FieldOffset(40)]
        public IntPtr RealtimeConnectContext;
        [FieldOffset(48)]
        public IntPtr DisconnectEvent;
        [FieldOffset(56)]
        public IntPtr DataAvailableEvent;
        [FieldOffset(64)]
        public IntPtr UserBufferCount;
        [FieldOffset(72)]
        public IntPtr UserBufferListHead;
        [FieldOffset(80)]
        public uint BuffersLost;
        [FieldOffset(84)]
        public uint EmptyBuffersCount;
        [FieldOffset(88)]
        public ushort LoggerId;
        [FieldOffset(90)]
        public byte Flags;
        [FieldOffset(90)]
        public byte ShutDownRequested;
        [FieldOffset(90)]
        public byte NewBuffersLost;
        [FieldOffset(90)]
        public byte Disconnected;
        [FieldOffset(90)]
        public byte Notified;
        [FieldOffset(90)]
        public byte Wow;
        [FieldOffset(96)]
        public _RTL_BITMAP ReservedBufferSpaceBitMap;
        [FieldOffset(112)]
        public IntPtr ReservedBufferSpace;
        [FieldOffset(120)]
        public uint ReservedBufferSpaceSize;
        [FieldOffset(124)]
        public uint UserPagesAllocated;
        [FieldOffset(128)]
        public uint UserPagesReused;
        [FieldOffset(136)]
        public IntPtr EventsLostCount;
        [FieldOffset(144)]
        public IntPtr BuffersLostCount;
        [FieldOffset(152)]
        public IntPtr SiloState;
    }
}