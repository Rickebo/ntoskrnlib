using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_MODWRITE_DATA")]
    public sealed class _MI_MODWRITE_DATA : DynamicStructure
    {
        public long PagesLoad { get; }
        public ulong PagesAverage { get; }
        public ulong AverageAvailablePages { get; }
        public ulong PagesWritten { get; }
        public uint WritesIssued { get; }
        public uint IgnoredReservationsCount { get; }
        public uint FreedReservationsCount { get; }
        public uint WriteBurstCount { get; }
        public ulong IgnoreReservationsStartTime { get; }
        public _MI_RESERVATION_CLUSTER_INFO ReservationClusterInfo { get; }
        public ushort IgnoreReservations { get; }
        public ushort Spare { get; }
        public ushort Spare1 { get; }

        public _MI_MODWRITE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_MODWRITE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_MODWRITE_DATA.PagesLoad),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.PagesAverage),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.AverageAvailablePages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.PagesWritten),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.WritesIssued),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.IgnoredReservationsCount),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.FreedReservationsCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.WriteBurstCount),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.IgnoreReservationsStartTime),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.ReservationClusterInfo),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.IgnoreReservations),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.Spare),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_MI_MODWRITE_DATA.Spare1),
                    new ulong[]
                    {
                        62UL
                    }
                }
            };
            Register<_MI_MODWRITE_DATA>((mem, ptr) => new _MI_MODWRITE_DATA(mem, ptr), offsets);
        }
    }
}