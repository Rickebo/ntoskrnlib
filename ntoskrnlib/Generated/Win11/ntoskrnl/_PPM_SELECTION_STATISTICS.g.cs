#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public partial struct _PPM_SELECTION_STATISTICS
    {
        [FieldOffset(0)]
        public ulong SelectedCount;
        [FieldOffset(8)]
        public ulong VetoCount;
        [FieldOffset(16)]
        public ulong PreVetoCount;
        [FieldOffset(24)]
        public ulong WrongProcessorCount;
        [FieldOffset(32)]
        public ulong LatencyCount;
        [FieldOffset(40)]
        public ulong IdleDurationCount;
        [FieldOffset(48)]
        public ulong DeviceDependencyCount;
        [FieldOffset(56)]
        public ulong ProcessorDependencyCount;
        [FieldOffset(64)]
        public ulong PlatformOnlyCount;
        [FieldOffset(72)]
        public ulong InterruptibleCount;
        [FieldOffset(80)]
        public ulong LegacyOverrideCount;
        [FieldOffset(88)]
        public ulong CstateCheckCount;
        [FieldOffset(96)]
        public ulong NoCStateCount;
        [FieldOffset(104)]
        public ulong CoordinatedDependencyCount;
        [FieldOffset(112)]
        public ulong NotClockOwnerCount;
        [FieldOffset(120)]
        public ulong DependencyIdleDurationCount;
        [FieldOffset(128)]
        public ulong DependencyLatencyCount;
        [FieldOffset(136)]
        public IntPtr PreVetoAccounting;
    }
}