using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SILO_USER_SHARED_DATA")]
    public sealed class _SILO_USER_SHARED_DATA : DynamicStructure
    {
        public uint ServiceSessionId { get; }
        public uint ActiveConsoleId { get; }
        public long ConsoleSessionForegroundProcessId { get; }
        public uint NtProductType { get; }
        public uint SuiteMask { get; }
        public uint SharedUserSessionId { get; }
        public byte IsMultiSessionSku { get; }
        public byte IsStateSeparationEnabled { get; }
        public short[] NtSystemRoot { get; }
        public ushort[] UserModeGlobalLogger { get; }
        public uint TimeZoneId { get; }
        public int TimeZoneBiasStamp { get; }
        public _KSYSTEM_TIME TimeZoneBias { get; }
        public _LARGE_INTEGER TimeZoneBiasEffectiveStart { get; }
        public _LARGE_INTEGER TimeZoneBiasEffectiveEnd { get; }

        public _SILO_USER_SHARED_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SILO_USER_SHARED_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SILO_USER_SHARED_DATA.ServiceSessionId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.ActiveConsoleId),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.ConsoleSessionForegroundProcessId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.NtProductType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.SuiteMask),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.SharedUserSessionId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.IsMultiSessionSku),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.IsStateSeparationEnabled),
                    new ulong[]
                    {
                        29UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.NtSystemRoot),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.UserModeGlobalLogger),
                    new ulong[]
                    {
                        550UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.TimeZoneId),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.TimeZoneBiasStamp),
                    new ulong[]
                    {
                        588UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.TimeZoneBias),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.TimeZoneBiasEffectiveStart),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_SILO_USER_SHARED_DATA.TimeZoneBiasEffectiveEnd),
                    new ulong[]
                    {
                        616UL
                    }
                }
            };
            Register<_SILO_USER_SHARED_DATA>((mem, ptr) => new _SILO_USER_SHARED_DATA(mem, ptr), offsets);
        }
    }
}