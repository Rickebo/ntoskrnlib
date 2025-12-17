#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _PLUGPLAY_CONTROL_STATUS_DATA
    {
        [FieldOffset(0)]
        public _UNICODE_STRING DeviceInstance;
        [FieldOffset(16)]
        public uint Operation;
        [FieldOffset(20)]
        public uint DeviceStatus;
        [FieldOffset(24)]
        public uint DeviceProblem;
        [FieldOffset(28)]
        public uint Flags;
        [FieldOffset(32)]
        public int ProblemStatus;
    }
}