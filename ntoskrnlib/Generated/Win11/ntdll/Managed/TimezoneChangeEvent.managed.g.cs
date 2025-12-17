using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TIMEZONE_CHANGE_EVENT")]
    public sealed class TimezoneChangeEvent : DynamicStructure
    {
        [Offset(0UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(64UL)]
        public Ktimer Timer { get => ReadStructure<Ktimer>(nameof(Timer)); set => WriteStructure(nameof(Timer), value); }

        [Offset(128UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        public TimezoneChangeEvent(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TimezoneChangeEvent>();
        }
    }
}