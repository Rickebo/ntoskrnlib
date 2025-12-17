using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_OBJECT_POWER_EXTENSION")]
    public sealed class _DEVICE_OBJECT_POWER_EXTENSION : DynamicStructure
    {
        public uint IdleCount { get; }
        public uint BusyCount { get; }
        public uint BusyReference { get; }
        public uint TotalBusyCount { get; }
        public uint ConservationIdleTime { get; }
        public uint PerformanceIdleTime { get; }
        public IntPtr DeviceObject { get; }
        public _LIST_ENTRY IdleList { get; }
        public uint IdleType { get; }
        public uint IdleState { get; }
        public uint CurrentState { get; }
        public IntPtr CoolingExtension { get; }
        public IntPtr PowerLimitExtension { get; }
        public _LIST_ENTRY Volume { get; }
        public _unnamed_tag_ Specific { get; }

        public _DEVICE_OBJECT_POWER_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_OBJECT_POWER_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.IdleCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.BusyCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.BusyReference),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.TotalBusyCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.ConservationIdleTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.PerformanceIdleTime),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.DeviceObject),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.IdleList),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.IdleType),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.IdleState),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.CurrentState),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.CoolingExtension),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.PowerLimitExtension),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.Volume),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT_POWER_EXTENSION.Specific),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_DEVICE_OBJECT_POWER_EXTENSION>((mem, ptr) => new _DEVICE_OBJECT_POWER_EXTENSION(mem, ptr), offsets);
        }
    }
}