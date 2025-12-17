using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OPLOCK_TELEMETRY")]
    public sealed class _OPLOCK_TELEMETRY : DynamicStructure
    {
        public long OplockBreakQpc { get; }
        public uint TelemetryFlags { get; }

        public _OPLOCK_TELEMETRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OPLOCK_TELEMETRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OPLOCK_TELEMETRY.OplockBreakQpc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OPLOCK_TELEMETRY.TelemetryFlags),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OPLOCK_TELEMETRY>((mem, ptr) => new _OPLOCK_TELEMETRY(mem, ptr), offsets);
        }
    }
}