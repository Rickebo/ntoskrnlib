#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 448)]
    public partial struct _THREAD_PERFORMANCE_DATA
    {
        [FieldOffset(0)]
        public ushort Size;
        [FieldOffset(2)]
        public ushort Version;
        [FieldOffset(4)]
        public _PROCESSOR_NUMBER ProcessorNumber;
        [FieldOffset(8)]
        public uint ContextSwitches;
        [FieldOffset(12)]
        public uint HwCountersCount;
        [FieldOffset(16)]
        public ulong UpdateCount;
        [FieldOffset(24)]
        public ulong WaitReasonBitMap;
        [FieldOffset(32)]
        public ulong HardwareCounters;
        [FieldOffset(40)]
        public _COUNTER_READING CycleTime;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _COUNTER_READING[] HwCounters;
    }
}