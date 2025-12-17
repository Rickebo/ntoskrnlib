using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_EX_TIMEZONE_STATE")]
    public sealed class _EX_TIMEZONE_STATE : DynamicStructure
    {
        public _RTL_DYNAMIC_TIME_ZONE_INFORMATION TimeZoneInformation { get; }
        public uint CurrentTimeZoneId { get; }
        public int LastTimeZoneBias { get; }
        public _LARGE_INTEGER TimeZoneBias { get; }
        public _TIMEZONE_CHANGE_EVENT TimeZone { get; }
        public _TIMEZONE_CHANGE_EVENT Century { get; }
        public _TIMEZONE_CHANGE_EVENT NextYear { get; }
        public int OkToTimeZoneRefresh { get; }
        public _LARGE_INTEGER NextCenturyTimeInUTC { get; }
        public _TIME_FIELDS NextCenturyTimeFieldsInLocalTime { get; }
        public _LARGE_INTEGER NextYearTimeInUTC { get; }
        public _TIME_FIELDS NextYearTimeFieldsInLocalTime { get; }
        public short LastDynamicTimeZoneYear { get; }
        public _LARGE_INTEGER NextSystemCutoverInUTC { get; }
        public uint RefreshFailures { get; }

        public _EX_TIMEZONE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_TIMEZONE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_TIMEZONE_STATE.TimeZoneInformation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.CurrentTimeZoneId),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.LastTimeZoneBias),
                    new ulong[]
                    {
                        436UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.TimeZoneBias),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.TimeZone),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.Century),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.NextYear),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.OkToTimeZoneRefresh),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.NextCenturyTimeInUTC),
                    new ulong[]
                    {
                        936UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.NextCenturyTimeFieldsInLocalTime),
                    new ulong[]
                    {
                        944UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.NextYearTimeInUTC),
                    new ulong[]
                    {
                        960UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.NextYearTimeFieldsInLocalTime),
                    new ulong[]
                    {
                        968UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.LastDynamicTimeZoneYear),
                    new ulong[]
                    {
                        984UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.NextSystemCutoverInUTC),
                    new ulong[]
                    {
                        992UL
                    }
                },
                {
                    nameof(_EX_TIMEZONE_STATE.RefreshFailures),
                    new ulong[]
                    {
                        1000UL
                    }
                }
            };
            Register<_EX_TIMEZONE_STATE>((mem, ptr) => new _EX_TIMEZONE_STATE(mem, ptr), offsets);
        }
    }
}