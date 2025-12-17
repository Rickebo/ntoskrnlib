#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public partial struct _INTERRUPT_TRACKING_ROOT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public _LIST_ENTRY TrackingEntryList;
        [FieldOffset(32)]
        public uint Gsiv;
        [FieldOffset(40)]
        public _INTERRUPT_VECTOR_DATA VectorData;
        [FieldOffset(128)]
        public uint SteeringMode;
        [FieldOffset(132)]
        public byte EnableSteering;
        [FieldOffset(136)]
        public _GROUP_AFFINITY CpuSetMask;
        [FieldOffset(152)]
        public ulong AffinityEpoch;
        [FieldOffset(160)]
        public _GROUP_AFFINITY CurrentTarget;
        [FieldOffset(176)]
        public _GROUP_AFFINITY NextTarget;
        [FieldOffset(192)]
        public ulong TimeDelta;
        [FieldOffset(200)]
        public IntPtr RedirectHandle;
        [FieldOffset(208)]
        public _LIST_ENTRY SteerQueueLink;
    }
}