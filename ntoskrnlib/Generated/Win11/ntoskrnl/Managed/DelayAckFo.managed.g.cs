using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DELAY_ACK_FO")]
    public sealed class DelayAckFo : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(16UL)]
        public IntPtr OriginalFileObject { get => ReadHere<IntPtr>(nameof(OriginalFileObject)); set => WriteHere(nameof(OriginalFileObject), value); }

        [Offset(24UL)]
        public OplockTelemetry TelemetryData { get => ReadStructure<OplockTelemetry>(nameof(TelemetryData)); set => WriteStructure(nameof(TelemetryData), value); }

        [Offset(40UL)]
        public IntPtr AckTimeout { get => ReadHere<IntPtr>(nameof(AckTimeout)); set => WriteHere(nameof(AckTimeout), value); }

        public DelayAckFo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DelayAckFo>();
        }
    }
}