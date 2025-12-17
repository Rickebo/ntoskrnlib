using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PLUGPLAY_CONTROL_STATUS_DATA")]
    public sealed class _PLUGPLAY_CONTROL_STATUS_DATA : DynamicStructure
    {
        public _UNICODE_STRING DeviceInstance { get; }
        public uint Operation { get; }
        public uint DeviceStatus { get; }
        public uint DeviceProblem { get; }
        public uint Flags { get; }
        public int ProblemStatus { get; }

        public _PLUGPLAY_CONTROL_STATUS_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PLUGPLAY_CONTROL_STATUS_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PLUGPLAY_CONTROL_STATUS_DATA.DeviceInstance),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PLUGPLAY_CONTROL_STATUS_DATA.Operation),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PLUGPLAY_CONTROL_STATUS_DATA.DeviceStatus),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PLUGPLAY_CONTROL_STATUS_DATA.DeviceProblem),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PLUGPLAY_CONTROL_STATUS_DATA.Flags),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PLUGPLAY_CONTROL_STATUS_DATA.ProblemStatus),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_PLUGPLAY_CONTROL_STATUS_DATA>((mem, ptr) => new _PLUGPLAY_CONTROL_STATUS_DATA(mem, ptr), offsets);
        }
    }
}