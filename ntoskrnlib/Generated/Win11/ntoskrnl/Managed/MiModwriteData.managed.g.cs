using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_MODWRITE_DATA")]
    public sealed class MiModwriteData : DynamicStructure
    {
        [Offset(0UL)]
        public long PagesLoad { get => ReadHere<long>(nameof(PagesLoad)); set => WriteHere(nameof(PagesLoad), value); }

        [Offset(8UL)]
        public ulong PagesAverage { get => ReadHere<ulong>(nameof(PagesAverage)); set => WriteHere(nameof(PagesAverage), value); }

        [Offset(16UL)]
        public ulong AverageAvailablePages { get => ReadHere<ulong>(nameof(AverageAvailablePages)); set => WriteHere(nameof(AverageAvailablePages), value); }

        [Offset(24UL)]
        public ulong PagesWritten { get => ReadHere<ulong>(nameof(PagesWritten)); set => WriteHere(nameof(PagesWritten), value); }

        [Offset(32UL)]
        public uint WritesIssued { get => ReadHere<uint>(nameof(WritesIssued)); set => WriteHere(nameof(WritesIssued), value); }

        [Offset(36UL)]
        public uint IgnoredReservationsCount { get => ReadHere<uint>(nameof(IgnoredReservationsCount)); set => WriteHere(nameof(IgnoredReservationsCount), value); }

        [Offset(40UL)]
        public uint FreedReservationsCount { get => ReadHere<uint>(nameof(FreedReservationsCount)); set => WriteHere(nameof(FreedReservationsCount), value); }

        [Offset(44UL)]
        public uint WriteBurstCount { get => ReadHere<uint>(nameof(WriteBurstCount)); set => WriteHere(nameof(WriteBurstCount), value); }

        [Offset(48UL)]
        public ulong IgnoreReservationsStartTime { get => ReadHere<ulong>(nameof(IgnoreReservationsStartTime)); set => WriteHere(nameof(IgnoreReservationsStartTime), value); }

        [Offset(56UL)]
        public MiReservationClusterInfo ReservationClusterInfo { get => ReadStructure<MiReservationClusterInfo>(nameof(ReservationClusterInfo)); set => WriteStructure(nameof(ReservationClusterInfo), value); }

        [Offset(60UL)]
        public ushort IgnoreReservations { get => ReadHere<ushort>(nameof(IgnoreReservations)); set => WriteHere(nameof(IgnoreReservations), value); }

        [Offset(60UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(62UL)]
        public ushort Spare1 { get => ReadHere<ushort>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        public MiModwriteData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiModwriteData>();
        }
    }
}