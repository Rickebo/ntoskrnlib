#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _KCLOCK_INCREMENT_TRACE
    {
        [FieldOffset(0)]
        public uint ActualIncrement;
        [FieldOffset(4)]
        public uint RequestedIncrement;
        [FieldOffset(8)]
        public ulong InterruptTime;
        [FieldOffset(16)]
        public ulong PerformanceCounter;
        [FieldOffset(24)]
        public byte OneShot;
    }
}