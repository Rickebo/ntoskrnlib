#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _POP_FX_DRIVER_CALLBACKS
    {
        [FieldOffset(0)]
        public IntPtr ComponentActive;
        [FieldOffset(8)]
        public IntPtr ComponentIdle;
        [FieldOffset(16)]
        public IntPtr ComponentIdleState;
        [FieldOffset(24)]
        public IntPtr DevicePowerRequired;
        [FieldOffset(32)]
        public IntPtr DevicePowerNotRequired;
        [FieldOffset(40)]
        public IntPtr PowerControl;
        [FieldOffset(48)]
        public IntPtr ComponentCriticalTransition;
        [FieldOffset(56)]
        public IntPtr DripsWatchdogCallback;
        [FieldOffset(64)]
        public IntPtr DirectedPowerUpCallback;
        [FieldOffset(72)]
        public IntPtr DirectedPowerDownCallback;
    }
}