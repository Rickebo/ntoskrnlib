#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 768)]
    public partial struct _KSCHEDULER_SUBNODE
    {
        [FieldOffset(0)]
        public ulong SubNodeLock;
        [FieldOffset(8)]
        public ulong IdleNonParkedCpuSet;
        [FieldOffset(16)]
        public ulong IdleCpuSet;
        [FieldOffset(24)]
        public ulong IdleSmtSet;
        [FieldOffset(32)]
        public ulong IdleModuleSet;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] IdleIsolationUnitSet;
        [FieldOffset(40)]
        public ulong NonPairedSmtSet;
        [FieldOffset(48)]
        public ulong ThreadQosGroupingSet;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] Spare1;
        [FieldOffset(64)]
        public ulong DeepIdleSet;
        [FieldOffset(72)]
        public ulong IdleConstrainedSet;
        [FieldOffset(80)]
        public ulong NonParkedSet;
        [FieldOffset(88)]
        public ulong ParkRequestSet;
        [FieldOffset(96)]
        public ulong SoftParkRequestSet;
        [FieldOffset(104)]
        public ulong ForceParkRequestSet;
        [FieldOffset(112)]
        public ulong NonIsrTargetedSet;
        [FieldOffset(120)]
        public int ParkLock;
        [FieldOffset(124)]
        public byte ProcessSeed;
        [FieldOffset(125)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Spare5;
        [FieldOffset(128)]
        public _GROUP_AFFINITY Affinity;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] AffinityFill;
        [FieldOffset(138)]
        public ushort ParentNodeNumber;
        [FieldOffset(140)]
        public ushort SubNodeNumber;
        [FieldOffset(142)]
        public ushort Spare;
        [FieldOffset(144)]
        public ulong SiblingMask;
        [FieldOffset(152)]
        public ulong SharedReadyQueueMask;
        [FieldOffset(160)]
        public ulong StrideMask;
        [FieldOffset(168)]
        public ulong LLCLeaders;
        [FieldOffset(176)]
        public uint Lowest;
        [FieldOffset(180)]
        public uint Highest;
        [FieldOffset(184)]
        public _flags Flags;
        [FieldOffset(185)]
        public byte WorkloadClasses;
        [FieldOffset(192)]
        public IntPtr HeteroSets;
        [FieldOffset(200)]
        public IntPtr PerformanceRanks;
        [FieldOffset(208)]
        public IntPtr EfficiencyRanks;
        [FieldOffset(216)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] Spare6;
        [FieldOffset(256)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public ulong[] PpmConfiguredQosSets;
        [FieldOffset(312)]
        public ulong Spare7;
        [FieldOffset(320)]
        public _KQOS_GROUPING_SETS PpmQosGroupingSets;
        [FieldOffset(336)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ulong[] Spare8;
        [FieldOffset(384)]
        public ulong StealableLocalReadyQueues;
        [FieldOffset(392)]
        public ulong StealableSharedReadyQueues;
        [FieldOffset(400)]
        public ulong StealableStandbyThreads;
        [FieldOffset(408)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] Spare9;
        [FieldOffset(448)]
        public _KRANK_LIST SoftParkRanks;
        [FieldOffset(512)]
        public _KRANK_LIST CoreShareCounts;
        [FieldOffset(576)]
        public _KRANK_LIST ModuleShareCounts;
        [FieldOffset(640)]
        public _KRANK_LIST ThreadQosGroupingCoreShareCounts;
        [FieldOffset(704)]
        public _KRANK_LIST ThreadQosGroupingModuleShareCounts;
    }
}