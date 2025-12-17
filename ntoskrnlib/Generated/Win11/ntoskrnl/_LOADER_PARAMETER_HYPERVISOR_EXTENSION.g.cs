#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _LOADER_PARAMETER_HYPERVISOR_EXTENSION
    {
        [FieldOffset(0)]
        public uint InitialHypervisorCrashdumpAreaPageCount;
        [FieldOffset(4)]
        public uint HypervisorCrashdumpAreaPageCount;
        [FieldOffset(8)]
        public ulong InitialHypervisorCrashdumpAreaSpa;
        [FieldOffset(16)]
        public ulong HypervisorCrashdumpAreaSpa;
        [FieldOffset(24)]
        public ulong HypervisorLaunchStatus;
        [FieldOffset(32)]
        public ulong HypervisorLaunchStatusArg1;
        [FieldOffset(40)]
        public ulong HypervisorLaunchStatusArg2;
        [FieldOffset(48)]
        public ulong HypervisorLaunchStatusArg3;
        [FieldOffset(56)]
        public ulong HypervisorLaunchStatusArg4;
        [FieldOffset(40)]
        public IntPtr RangeArray;
        [FieldOffset(48)]
        public uint RangeCount;
    }
}