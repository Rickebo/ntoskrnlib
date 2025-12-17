#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_MODWRITE_DATA
    {
        [FieldOffset(0)]
        public long PagesLoad;
        [FieldOffset(8)]
        public ulong PagesAverage;
        [FieldOffset(16)]
        public ulong AverageAvailablePages;
        [FieldOffset(24)]
        public ulong PagesWritten;
        [FieldOffset(32)]
        public uint WritesIssued;
        [FieldOffset(36)]
        public uint IgnoredReservationsCount;
        [FieldOffset(40)]
        public uint FreedReservationsCount;
        [FieldOffset(44)]
        public uint WriteBurstCount;
        [FieldOffset(48)]
        public ulong IgnoreReservationsStartTime;
        [FieldOffset(56)]
        public _MI_RESERVATION_CLUSTER_INFO ReservationClusterInfo;
        [FieldOffset(60)]
        public ushort IgnoreReservations;
        [FieldOffset(60)]
        public ushort Spare;
        [FieldOffset(62)]
        public ushort Spare1;
    }
}