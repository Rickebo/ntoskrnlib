#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 376)]
    public partial struct _KNODE
    {
        [FieldOffset(0)]
        public ushort NodeNumber;
        [FieldOffset(2)]
        public ushort PrimaryNodeNumber;
        [FieldOffset(4)]
        public uint ProximityId;
        [FieldOffset(8)]
        public ushort MaximumProcessors;
        [FieldOffset(10)]
        public _unnamed_tag_ Flags;
        [FieldOffset(11)]
        public byte GroupSeed;
        [FieldOffset(12)]
        public byte PrimaryGroup;
        [FieldOffset(13)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Padding;
        [FieldOffset(16)]
        public _KGROUP_MASK ActiveGroups;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public IntPtr[] SchedulerSubNodes;
        [FieldOffset(288)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] ActiveTopologyElements;
        [FieldOffset(308)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _KNODE_SUBNODE_SEARCH_RANKS[] PerformanceSearchRanks;
        [FieldOffset(340)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _KNODE_SUBNODE_SEARCH_RANKS[] EfficiencySearchRanks;
    }
}