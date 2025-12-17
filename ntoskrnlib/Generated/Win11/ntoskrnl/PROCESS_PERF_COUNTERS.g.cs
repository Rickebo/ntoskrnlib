#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 216)]
    public partial struct PROCESS_PERF_COUNTERS
    {
        [FieldOffset(0)]
        public ulong ProcessorTime;
        [FieldOffset(8)]
        public ulong UserTime;
        [FieldOffset(16)]
        public ulong PrivilegedTime;
        [FieldOffset(24)]
        public ulong VirtualBytesPeak;
        [FieldOffset(32)]
        public ulong VirtualBytes;
        [FieldOffset(40)]
        public uint PageFaults;
        [FieldOffset(44)]
        public uint HandleCount;
        [FieldOffset(48)]
        public ulong WorkingSetPeak;
        [FieldOffset(56)]
        public ulong WorkingSet;
        [FieldOffset(64)]
        public ulong PageFileBytesPeak;
        [FieldOffset(72)]
        public ulong PageFileBytes;
        [FieldOffset(80)]
        public ulong PrivateBytes;
        [FieldOffset(88)]
        public uint ThreadCount;
        [FieldOffset(92)]
        public uint PriorityBase;
        [FieldOffset(96)]
        public ulong ElapsedTime;
        [FieldOffset(104)]
        public uint ProcessId;
        [FieldOffset(108)]
        public uint CreatingProcessId;
        [FieldOffset(112)]
        public ulong PoolPagedBytes;
        [FieldOffset(120)]
        public ulong PoolNonpagedBytes;
        [FieldOffset(128)]
        public ulong IoReadOperations;
        [FieldOffset(136)]
        public ulong IoWriteOperations;
        [FieldOffset(144)]
        public ulong IoDataOperations;
        [FieldOffset(152)]
        public ulong IoOtherOperations;
        [FieldOffset(160)]
        public ulong IoReadBytes;
        [FieldOffset(168)]
        public ulong IoWriteBytes;
        [FieldOffset(176)]
        public ulong IoDataBytes;
        [FieldOffset(184)]
        public ulong IoOtherBytes;
        [FieldOffset(192)]
        public ulong WorkingSetPrivate;
        [FieldOffset(200)]
        public ulong PerfFreq;
        [FieldOffset(208)]
        public ulong PerfTime;
    }
}