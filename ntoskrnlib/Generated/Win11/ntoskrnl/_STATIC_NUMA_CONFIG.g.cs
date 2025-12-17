#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _STATIC_NUMA_CONFIG
    {
        [FieldOffset(0)]
        public IntPtr ProcessorLocalId;
        [FieldOffset(8)]
        public IntPtr ProcessorUid;
        [FieldOffset(16)]
        public IntPtr ProcessorProximity;
        [FieldOffset(24)]
        public IntPtr ProximityId;
        [FieldOffset(32)]
        public IntPtr OrigProximityId;
        [FieldOffset(40)]
        public IntPtr NodeCapacity;
        [FieldOffset(48)]
        public IntPtr NodeDistance;
        [FieldOffset(56)]
        public uint NodeCount;
        [FieldOffset(60)]
        public uint ProcessorCount;
        [FieldOffset(64)]
        public uint AllocatedNodeCount;
        [FieldOffset(68)]
        public uint AllocatedProcCount;
    }
}