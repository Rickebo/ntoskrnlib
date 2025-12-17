using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_EVENT_LOG_ENTRY")]
    public sealed class WheaEventLogEntry : DynamicStructure
    {
        [Offset(0UL)]
        public WheaEventLogEntryHeader Header { get => ReadStructure<WheaEventLogEntryHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        public WheaEventLogEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaEventLogEntry>();
        }
    }
}