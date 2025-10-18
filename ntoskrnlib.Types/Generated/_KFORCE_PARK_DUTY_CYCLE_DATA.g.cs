using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=344)]
public struct _KFORCE_PARK_DUTY_CYCLE_DATA
{
    [FieldOffset(0)]
    public _KDPC DutyCycleDpc;
    [FieldOffset(64)]
    public _KTIMER2 StartSingleDutyCycleTimer;
    [FieldOffset(200)]
    public _KTIMER2 StopSingleDutyCycleTimer;
    [FieldOffset(336)]
    public IntPtr CurrentState;
    [FieldOffset(340)]
    public IntPtr DpcTransition;
}
