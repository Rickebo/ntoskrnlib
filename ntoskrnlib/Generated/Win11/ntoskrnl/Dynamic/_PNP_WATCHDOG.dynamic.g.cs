using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_WATCHDOG")]
    public sealed class _PNP_WATCHDOG : DynamicStructure
    {
        public ulong WatchdogStart { get; }
        public IntPtr WatchdogTimer { get; }
        public uint WatchdogContextType { get; }
        public IntPtr WatchdogContext { get; }
        public byte FirstChanceTriggered { get; }
        public byte TelemetryGenerated { get; }
        public _UNICODE_STRING DriverToBlame { get; }
        public short[] DriverToBlameBuffer { get; }

        public _PNP_WATCHDOG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_WATCHDOG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_WATCHDOG.WatchdogStart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_WATCHDOG.WatchdogTimer),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PNP_WATCHDOG.WatchdogContextType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PNP_WATCHDOG.WatchdogContext),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PNP_WATCHDOG.FirstChanceTriggered),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PNP_WATCHDOG.TelemetryGenerated),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_PNP_WATCHDOG.DriverToBlame),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PNP_WATCHDOG.DriverToBlameBuffer),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_PNP_WATCHDOG>((mem, ptr) => new _PNP_WATCHDOG(mem, ptr), offsets);
        }
    }
}