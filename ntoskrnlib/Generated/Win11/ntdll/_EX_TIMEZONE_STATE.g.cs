#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1008)]
    public partial struct _EX_TIMEZONE_STATE
    {
        [FieldOffset(0)]
        public _RTL_DYNAMIC_TIME_ZONE_INFORMATION TimeZoneInformation;
        [FieldOffset(432)]
        public uint CurrentTimeZoneId;
        [FieldOffset(436)]
        public int LastTimeZoneBias;
        [FieldOffset(440)]
        public _LARGE_INTEGER TimeZoneBias;
        [FieldOffset(448)]
        public _TIMEZONE_CHANGE_EVENT TimeZone;
        [FieldOffset(608)]
        public _TIMEZONE_CHANGE_EVENT Century;
        [FieldOffset(768)]
        public _TIMEZONE_CHANGE_EVENT NextYear;
        [FieldOffset(928)]
        public int OkToTimeZoneRefresh;
        [FieldOffset(936)]
        public _LARGE_INTEGER NextCenturyTimeInUTC;
        [FieldOffset(944)]
        public _TIME_FIELDS NextCenturyTimeFieldsInLocalTime;
        [FieldOffset(960)]
        public _LARGE_INTEGER NextYearTimeInUTC;
        [FieldOffset(968)]
        public _TIME_FIELDS NextYearTimeFieldsInLocalTime;
        [FieldOffset(984)]
        public short LastDynamicTimeZoneYear;
        [FieldOffset(992)]
        public _LARGE_INTEGER NextSystemCutoverInUTC;
        [FieldOffset(1000)]
        public uint RefreshFailures;
    }
}