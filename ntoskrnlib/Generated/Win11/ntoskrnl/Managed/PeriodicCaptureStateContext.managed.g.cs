using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!PERIODIC_CAPTURE_STATE_CONTEXT")]
    public sealed class PeriodicCaptureStateContext : DynamicStructure
    {
        [Offset(0UL)]
        public long RelativeTimerDueTime { get => ReadHere<long>(nameof(RelativeTimerDueTime)); set => WriteHere(nameof(RelativeTimerDueTime), value); }

        [Offset(8UL)]
        public IntPtr Timer { get => ReadHere<IntPtr>(nameof(Timer)); set => WriteHere(nameof(Timer), value); }

        [Offset(16UL)]
        public PeriodicCaptureStateGuids Guids { get => ReadStructure<PeriodicCaptureStateGuids>(nameof(Guids)); set => WriteStructure(nameof(Guids), value); }

        [Offset(32UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(64UL)]
        public uint TimerState { get => ReadHere<uint>(nameof(TimerState)); set => WriteHere(nameof(TimerState), value); }

        public PeriodicCaptureStateContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PeriodicCaptureStateContext>();
        }
    }
}