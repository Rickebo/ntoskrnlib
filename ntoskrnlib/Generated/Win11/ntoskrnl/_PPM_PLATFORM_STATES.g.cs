#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 512)]
    public partial struct _PPM_PLATFORM_STATES
    {
        [FieldOffset(0)]
        public uint StateCount;
        [FieldOffset(4)]
        public uint ProcessorCount;
        [FieldOffset(8)]
        public byte CoordinatedInterface;
        [FieldOffset(16)]
        public IntPtr IdleTest;
        [FieldOffset(24)]
        public IntPtr IdlePreExecute;
        [FieldOffset(32)]
        public IntPtr IdleComplete;
        [FieldOffset(40)]
        public IntPtr QueryPlatformStateResidency;
        [FieldOffset(48)]
        public IntPtr Accounting;
        [FieldOffset(56)]
        public uint DeepSleepState;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PPM_PLATFORM_STATE[] State;
    }
}