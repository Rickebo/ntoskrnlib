using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OPLOCK_TELEMETRY")]
    public sealed class OplockTelemetry : DynamicStructure
    {
        [Offset(0UL)]
        public long OplockBreakQpc { get => ReadHere<long>(nameof(OplockBreakQpc)); set => WriteHere(nameof(OplockBreakQpc), value); }

        [Offset(8UL)]
        public uint TelemetryFlags { get => ReadHere<uint>(nameof(TelemetryFlags)); set => WriteHere(nameof(TelemetryFlags), value); }

        public OplockTelemetry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<OplockTelemetry>();
        }
    }
}