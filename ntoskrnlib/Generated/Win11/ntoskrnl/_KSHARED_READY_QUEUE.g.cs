#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1792)]
    public partial struct _KSHARED_READY_QUEUE
    {
        [FieldOffset(0)]
        public ulong Lock;
        [FieldOffset(8)]
        public uint ReadySummary;
        [FieldOffset(12)]
        public uint ReadyThreadCount;
        [FieldOffset(16)]
        public ulong ReadyQueueExpectedRunTime;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] Spare1;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public _LIST_ENTRY[] ReadyListHead;
        [FieldOffset(576)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _KPRIORITY_STATE[] RunningSummary;
        [FieldOffset(640)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _KHETERO_STATE[] HeteroRunningSummary;
        [FieldOffset(704)]
        public byte Span;
        [FieldOffset(705)]
        public byte LowProcIndex;
        [FieldOffset(706)]
        public byte QueueIndex;
        [FieldOffset(707)]
        public byte NormalPriorityQueueIndex;
        [FieldOffset(708)]
        public byte ProcCount;
        [FieldOffset(709)]
        public byte ScanOwner;
        [FieldOffset(710)]
        public ushort Group;
        [FieldOffset(712)]
        public ulong Affinity;
        [FieldOffset(720)]
        public IntPtr SubNode;
        [FieldOffset(728)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ulong[] Spare2;
        [FieldOffset(768)]
        public ulong SoftParkElectionLock;
        [FieldOffset(776)]
        public ulong SoftParkElectionGeneration;
        [FieldOffset(784)]
        public uint SoftParkElectionThreadCount;
        [FieldOffset(788)]
        public byte SoftParkElectionScheduled;
        [FieldOffset(789)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Spare4;
        [FieldOffset(792)]
        public ulong SoftParkElectionRunTime;
        [FieldOffset(800)]
        public _KDPC SoftParkElectionDpc;
        [FieldOffset(864)]
        public _KSHARED_READY_QUEUE_HETERO_STATISTICS SoftParkElectionHeteroStats;
        [FieldOffset(1760)]
        public _KSHARED_READY_QUEUE_AFFINITY_STATISTICS SoftParkElectionAffinityStats;
        [FieldOffset(1768)]
        public ulong ForceParkDutyCyclingArmedMask;
    }
}