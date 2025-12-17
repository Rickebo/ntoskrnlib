#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _DEVICE_OBJECT_POWER_EXTENSION
    {
        [FieldOffset(0)]
        public uint IdleCount;
        [FieldOffset(4)]
        public uint BusyCount;
        [FieldOffset(8)]
        public uint BusyReference;
        [FieldOffset(12)]
        public uint TotalBusyCount;
        [FieldOffset(16)]
        public uint ConservationIdleTime;
        [FieldOffset(20)]
        public uint PerformanceIdleTime;
        [FieldOffset(24)]
        public IntPtr DeviceObject;
        [FieldOffset(32)]
        public _LIST_ENTRY IdleList;
        [FieldOffset(48)]
        public uint IdleType;
        [FieldOffset(52)]
        public uint IdleState;
        [FieldOffset(56)]
        public uint CurrentState;
        [FieldOffset(64)]
        public IntPtr CoolingExtension;
        [FieldOffset(72)]
        public IntPtr PowerLimitExtension;
        [FieldOffset(80)]
        public _LIST_ENTRY Volume;
        [FieldOffset(96)]
        public _unnamed_tag_ Specific;
    }
}