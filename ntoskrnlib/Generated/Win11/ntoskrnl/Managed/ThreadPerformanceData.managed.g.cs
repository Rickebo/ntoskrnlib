using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_THREAD_PERFORMANCE_DATA")]
    public sealed class ThreadPerformanceData : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(2UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public ProcessorNumber ProcessorNumber { get => ReadStructure<ProcessorNumber>(nameof(ProcessorNumber)); set => WriteStructure(nameof(ProcessorNumber), value); }

        [Offset(8UL)]
        public uint ContextSwitches { get => ReadHere<uint>(nameof(ContextSwitches)); set => WriteHere(nameof(ContextSwitches), value); }

        [Offset(12UL)]
        public uint HwCountersCount { get => ReadHere<uint>(nameof(HwCountersCount)); set => WriteHere(nameof(HwCountersCount), value); }

        [Offset(16UL)]
        public ulong UpdateCount { get => ReadHere<ulong>(nameof(UpdateCount)); set => WriteHere(nameof(UpdateCount), value); }

        [Offset(24UL)]
        public ulong WaitReasonBitMap { get => ReadHere<ulong>(nameof(WaitReasonBitMap)); set => WriteHere(nameof(WaitReasonBitMap), value); }

        [Offset(32UL)]
        public ulong HardwareCounters { get => ReadHere<ulong>(nameof(HardwareCounters)); set => WriteHere(nameof(HardwareCounters), value); }

        [Offset(40UL)]
        public CounterReading CycleTime { get => ReadStructure<CounterReading>(nameof(CycleTime)); set => WriteStructure(nameof(CycleTime), value); }

        [Offset(64UL)]
        [Length(16)]
        public DynamicArray HwCounters { get => ReadStructure<DynamicArray>(nameof(HwCounters)); set => WriteStructure(nameof(HwCounters), value); }

        public ThreadPerformanceData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ThreadPerformanceData>();
        }
    }
}