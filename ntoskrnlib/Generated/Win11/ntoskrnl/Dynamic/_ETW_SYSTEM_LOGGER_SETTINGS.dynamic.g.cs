using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_SYSTEM_LOGGER_SETTINGS")]
    public sealed class _ETW_SYSTEM_LOGGER_SETTINGS : DynamicStructure
    {
        public byte[] EtwpSystemLogger { get; }
        public uint EtwpActiveSystemLoggers { get; }
        public _PERFINFO_GROUPMASK SiloGlobalGroupMask { get; }
        public byte[] EtwpGroupMasks { get; }

        public _ETW_SYSTEM_LOGGER_SETTINGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_SYSTEM_LOGGER_SETTINGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_SYSTEM_LOGGER_SETTINGS.EtwpSystemLogger),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_SYSTEM_LOGGER_SETTINGS.EtwpActiveSystemLoggers),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_SYSTEM_LOGGER_SETTINGS.SiloGlobalGroupMask),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ETW_SYSTEM_LOGGER_SETTINGS.EtwpGroupMasks),
                    new ulong[]
                    {
                        52UL
                    }
                }
            };
            Register<_ETW_SYSTEM_LOGGER_SETTINGS>((mem, ptr) => new _ETW_SYSTEM_LOGGER_SETTINGS(mem, ptr), offsets);
        }
    }
}