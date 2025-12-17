#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 344)]
    public partial struct _KFORCE_PARK_DUTY_CYCLE_DATA
    {
        [FieldOffset(0)]
        public _KDPC DutyCycleDpc;
        [FieldOffset(64)]
        public _KTIMER2 StartSingleDutyCycleTimer;
        [FieldOffset(200)]
        public _KTIMER2 StopSingleDutyCycleTimer;
        [FieldOffset(336)]
        public uint CurrentState;
        [FieldOffset(340)]
        public uint DpcTransition;
    }
}