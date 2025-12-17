using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_FFH_THROTTLE_STATE_INFO")]
    public sealed class _PPM_FFH_THROTTLE_STATE_INFO : DynamicStructure
    {
        public byte EnableLogging { get; }
        public uint MismatchCount { get; }
        public byte Initialized { get; }
        public ulong LastValue { get; }
        public _LARGE_INTEGER LastLogTickCount { get; }

        public _PPM_FFH_THROTTLE_STATE_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_FFH_THROTTLE_STATE_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_FFH_THROTTLE_STATE_INFO.EnableLogging),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_FFH_THROTTLE_STATE_INFO.MismatchCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PPM_FFH_THROTTLE_STATE_INFO.Initialized),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_FFH_THROTTLE_STATE_INFO.LastValue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PPM_FFH_THROTTLE_STATE_INFO.LastLogTickCount),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_PPM_FFH_THROTTLE_STATE_INFO>((mem, ptr) => new _PPM_FFH_THROTTLE_STATE_INFO(mem, ptr), offsets);
        }
    }
}