using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!PROCESS_PERF_COUNTERS")]
    public sealed class ProcessPerfCounters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ProcessorTime { get => ReadHere<ulong>(nameof(ProcessorTime)); set => WriteHere(nameof(ProcessorTime), value); }

        [Offset(8UL)]
        public ulong UserTime { get => ReadHere<ulong>(nameof(UserTime)); set => WriteHere(nameof(UserTime), value); }

        [Offset(16UL)]
        public ulong PrivilegedTime { get => ReadHere<ulong>(nameof(PrivilegedTime)); set => WriteHere(nameof(PrivilegedTime), value); }

        [Offset(24UL)]
        public ulong VirtualBytesPeak { get => ReadHere<ulong>(nameof(VirtualBytesPeak)); set => WriteHere(nameof(VirtualBytesPeak), value); }

        [Offset(32UL)]
        public ulong VirtualBytes { get => ReadHere<ulong>(nameof(VirtualBytes)); set => WriteHere(nameof(VirtualBytes), value); }

        [Offset(40UL)]
        public uint PageFaults { get => ReadHere<uint>(nameof(PageFaults)); set => WriteHere(nameof(PageFaults), value); }

        [Offset(44UL)]
        public uint HandleCount { get => ReadHere<uint>(nameof(HandleCount)); set => WriteHere(nameof(HandleCount), value); }

        [Offset(48UL)]
        public ulong WorkingSetPeak { get => ReadHere<ulong>(nameof(WorkingSetPeak)); set => WriteHere(nameof(WorkingSetPeak), value); }

        [Offset(56UL)]
        public ulong WorkingSet { get => ReadHere<ulong>(nameof(WorkingSet)); set => WriteHere(nameof(WorkingSet), value); }

        [Offset(64UL)]
        public ulong PageFileBytesPeak { get => ReadHere<ulong>(nameof(PageFileBytesPeak)); set => WriteHere(nameof(PageFileBytesPeak), value); }

        [Offset(72UL)]
        public ulong PageFileBytes { get => ReadHere<ulong>(nameof(PageFileBytes)); set => WriteHere(nameof(PageFileBytes), value); }

        [Offset(80UL)]
        public ulong PrivateBytes { get => ReadHere<ulong>(nameof(PrivateBytes)); set => WriteHere(nameof(PrivateBytes), value); }

        [Offset(88UL)]
        public uint ThreadCount { get => ReadHere<uint>(nameof(ThreadCount)); set => WriteHere(nameof(ThreadCount), value); }

        [Offset(92UL)]
        public uint PriorityBase { get => ReadHere<uint>(nameof(PriorityBase)); set => WriteHere(nameof(PriorityBase), value); }

        [Offset(96UL)]
        public ulong ElapsedTime { get => ReadHere<ulong>(nameof(ElapsedTime)); set => WriteHere(nameof(ElapsedTime), value); }

        [Offset(104UL)]
        public uint ProcessId { get => ReadHere<uint>(nameof(ProcessId)); set => WriteHere(nameof(ProcessId), value); }

        [Offset(108UL)]
        public uint CreatingProcessId { get => ReadHere<uint>(nameof(CreatingProcessId)); set => WriteHere(nameof(CreatingProcessId), value); }

        [Offset(112UL)]
        public ulong PoolPagedBytes { get => ReadHere<ulong>(nameof(PoolPagedBytes)); set => WriteHere(nameof(PoolPagedBytes), value); }

        [Offset(120UL)]
        public ulong PoolNonpagedBytes { get => ReadHere<ulong>(nameof(PoolNonpagedBytes)); set => WriteHere(nameof(PoolNonpagedBytes), value); }

        [Offset(128UL)]
        public ulong IoReadOperations { get => ReadHere<ulong>(nameof(IoReadOperations)); set => WriteHere(nameof(IoReadOperations), value); }

        [Offset(136UL)]
        public ulong IoWriteOperations { get => ReadHere<ulong>(nameof(IoWriteOperations)); set => WriteHere(nameof(IoWriteOperations), value); }

        [Offset(144UL)]
        public ulong IoDataOperations { get => ReadHere<ulong>(nameof(IoDataOperations)); set => WriteHere(nameof(IoDataOperations), value); }

        [Offset(152UL)]
        public ulong IoOtherOperations { get => ReadHere<ulong>(nameof(IoOtherOperations)); set => WriteHere(nameof(IoOtherOperations), value); }

        [Offset(160UL)]
        public ulong IoReadBytes { get => ReadHere<ulong>(nameof(IoReadBytes)); set => WriteHere(nameof(IoReadBytes), value); }

        [Offset(168UL)]
        public ulong IoWriteBytes { get => ReadHere<ulong>(nameof(IoWriteBytes)); set => WriteHere(nameof(IoWriteBytes), value); }

        [Offset(176UL)]
        public ulong IoDataBytes { get => ReadHere<ulong>(nameof(IoDataBytes)); set => WriteHere(nameof(IoDataBytes), value); }

        [Offset(184UL)]
        public ulong IoOtherBytes { get => ReadHere<ulong>(nameof(IoOtherBytes)); set => WriteHere(nameof(IoOtherBytes), value); }

        [Offset(192UL)]
        public ulong WorkingSetPrivate { get => ReadHere<ulong>(nameof(WorkingSetPrivate)); set => WriteHere(nameof(WorkingSetPrivate), value); }

        [Offset(200UL)]
        public ulong PerfFreq { get => ReadHere<ulong>(nameof(PerfFreq)); set => WriteHere(nameof(PerfFreq), value); }

        [Offset(208UL)]
        public ulong PerfTime { get => ReadHere<ulong>(nameof(PerfTime)); set => WriteHere(nameof(PerfTime), value); }

        public ProcessPerfCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessPerfCounters>();
        }
    }
}