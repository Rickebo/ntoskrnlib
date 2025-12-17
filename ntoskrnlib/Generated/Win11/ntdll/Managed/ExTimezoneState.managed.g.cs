using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_EX_TIMEZONE_STATE")]
    public sealed class ExTimezoneState : DynamicStructure
    {
        [Offset(0UL)]
        public RtlDynamicTimeZoneInformation TimeZoneInformation { get => ReadStructure<RtlDynamicTimeZoneInformation>(nameof(TimeZoneInformation)); set => WriteStructure(nameof(TimeZoneInformation), value); }

        [Offset(432UL)]
        public uint CurrentTimeZoneId { get => ReadHere<uint>(nameof(CurrentTimeZoneId)); set => WriteHere(nameof(CurrentTimeZoneId), value); }

        [Offset(436UL)]
        public int LastTimeZoneBias { get => ReadHere<int>(nameof(LastTimeZoneBias)); set => WriteHere(nameof(LastTimeZoneBias), value); }

        [Offset(440UL)]
        public LargeInteger TimeZoneBias { get => ReadStructure<LargeInteger>(nameof(TimeZoneBias)); set => WriteStructure(nameof(TimeZoneBias), value); }

        [Offset(448UL)]
        public TimezoneChangeEvent TimeZone { get => ReadStructure<TimezoneChangeEvent>(nameof(TimeZone)); set => WriteStructure(nameof(TimeZone), value); }

        [Offset(608UL)]
        public TimezoneChangeEvent Century { get => ReadStructure<TimezoneChangeEvent>(nameof(Century)); set => WriteStructure(nameof(Century), value); }

        [Offset(768UL)]
        public TimezoneChangeEvent NextYear { get => ReadStructure<TimezoneChangeEvent>(nameof(NextYear)); set => WriteStructure(nameof(NextYear), value); }

        [Offset(928UL)]
        public int OkToTimeZoneRefresh { get => ReadHere<int>(nameof(OkToTimeZoneRefresh)); set => WriteHere(nameof(OkToTimeZoneRefresh), value); }

        [Offset(936UL)]
        public LargeInteger NextCenturyTimeInUTC { get => ReadStructure<LargeInteger>(nameof(NextCenturyTimeInUTC)); set => WriteStructure(nameof(NextCenturyTimeInUTC), value); }

        [Offset(944UL)]
        public TimeFields NextCenturyTimeFieldsInLocalTime { get => ReadStructure<TimeFields>(nameof(NextCenturyTimeFieldsInLocalTime)); set => WriteStructure(nameof(NextCenturyTimeFieldsInLocalTime), value); }

        [Offset(960UL)]
        public LargeInteger NextYearTimeInUTC { get => ReadStructure<LargeInteger>(nameof(NextYearTimeInUTC)); set => WriteStructure(nameof(NextYearTimeInUTC), value); }

        [Offset(968UL)]
        public TimeFields NextYearTimeFieldsInLocalTime { get => ReadStructure<TimeFields>(nameof(NextYearTimeFieldsInLocalTime)); set => WriteStructure(nameof(NextYearTimeFieldsInLocalTime), value); }

        [Offset(984UL)]
        public short LastDynamicTimeZoneYear { get => ReadHere<short>(nameof(LastDynamicTimeZoneYear)); set => WriteHere(nameof(LastDynamicTimeZoneYear), value); }

        [Offset(992UL)]
        public LargeInteger NextSystemCutoverInUTC { get => ReadStructure<LargeInteger>(nameof(NextSystemCutoverInUTC)); set => WriteStructure(nameof(NextSystemCutoverInUTC), value); }

        [Offset(1000UL)]
        public uint RefreshFailures { get => ReadHere<uint>(nameof(RefreshFailures)); set => WriteHere(nameof(RefreshFailures), value); }

        public ExTimezoneState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExTimezoneState>();
        }
    }
}