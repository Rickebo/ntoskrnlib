using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_REALTIME_CONSUMER")]
    public sealed class _ETW_REALTIME_CONSUMER : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public IntPtr ProcessHandle { get; }
        public IntPtr ProcessObject { get; }
        public IntPtr NextNotDelivered { get; }
        public IntPtr RealtimeConnectContext { get; }
        public IntPtr DisconnectEvent { get; }
        public IntPtr DataAvailableEvent { get; }
        public IntPtr UserBufferCount { get; }
        public IntPtr UserBufferListHead { get; }
        public uint BuffersLost { get; }
        public uint EmptyBuffersCount { get; }
        public ushort LoggerId { get; }
        public byte Flags { get; }
        public byte ShutDownRequested { get; }
        public byte NewBuffersLost { get; }
        public byte Disconnected { get; }
        public byte Notified { get; }
        public byte Wow { get; }
        public _RTL_BITMAP ReservedBufferSpaceBitMap { get; }
        public IntPtr ReservedBufferSpace { get; }
        public uint ReservedBufferSpaceSize { get; }
        public uint UserPagesAllocated { get; }
        public uint UserPagesReused { get; }
        public IntPtr EventsLostCount { get; }
        public IntPtr BuffersLostCount { get; }
        public IntPtr SiloState { get; }

        public _ETW_REALTIME_CONSUMER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_REALTIME_CONSUMER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_REALTIME_CONSUMER.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.ProcessHandle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.ProcessObject),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.NextNotDelivered),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.RealtimeConnectContext),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.DisconnectEvent),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.DataAvailableEvent),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.UserBufferCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.UserBufferListHead),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.BuffersLost),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.EmptyBuffersCount),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.LoggerId),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.Flags),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.ShutDownRequested),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.NewBuffersLost),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.Disconnected),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.Notified),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.Wow),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.ReservedBufferSpaceBitMap),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.ReservedBufferSpace),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.ReservedBufferSpaceSize),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.UserPagesAllocated),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.UserPagesReused),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.EventsLostCount),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.BuffersLostCount),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_ETW_REALTIME_CONSUMER.SiloState),
                    new ulong[]
                    {
                        152UL
                    }
                }
            };
            Register<_ETW_REALTIME_CONSUMER>((mem, ptr) => new _ETW_REALTIME_CONSUMER(mem, ptr), offsets);
        }
    }
}