#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _LOADER_PERFORMANCE_DATA
    {
        [FieldOffset(0)]
        public ulong StartTime;
        [FieldOffset(8)]
        public ulong EndTime;
        [FieldOffset(16)]
        public ulong PreloadEndTime;
        [FieldOffset(24)]
        public ulong TcbLoaderStartTime;
        [FieldOffset(32)]
        public ulong LoadHypervisorTime;
        [FieldOffset(40)]
        public ulong LaunchHypervisorTime;
        [FieldOffset(48)]
        public ulong LoadVsmTime;
        [FieldOffset(56)]
        public ulong LaunchVsmTime;
        [FieldOffset(64)]
        public ulong ExecuteTransitionStartTime;
        [FieldOffset(72)]
        public ulong ExecuteTransitionEndTime;
        [FieldOffset(80)]
        public ulong LoadDriversTime;
        [FieldOffset(88)]
        public ulong CleanupVsmTime;
    }
}