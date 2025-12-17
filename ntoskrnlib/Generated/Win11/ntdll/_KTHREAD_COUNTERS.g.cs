#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 424)]
    public partial struct _KTHREAD_COUNTERS
    {
        [FieldOffset(0)]
        public ulong WaitReasonBitMap;
        [FieldOffset(8)]
        public IntPtr UserData;
        [FieldOffset(16)]
        public uint Flags;
        [FieldOffset(20)]
        public uint ContextSwitches;
        [FieldOffset(24)]
        public ulong CycleTimeBias;
        [FieldOffset(32)]
        public ulong HardwareCounters;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _COUNTER_READING[] HwCounter;
    }
}