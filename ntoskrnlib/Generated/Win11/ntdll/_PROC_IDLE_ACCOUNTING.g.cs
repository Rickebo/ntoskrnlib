#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1056)]
    public partial struct _PROC_IDLE_ACCOUNTING
    {
        [FieldOffset(0)]
        public uint StateCount;
        [FieldOffset(4)]
        public uint TotalTransitions;
        [FieldOffset(8)]
        public uint ResetCount;
        [FieldOffset(12)]
        public uint AbortCount;
        [FieldOffset(16)]
        public ulong StartTime;
        [FieldOffset(24)]
        public ulong PriorIdleTime;
        [FieldOffset(32)]
        public uint TimeUnit;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PROC_IDLE_STATE_ACCOUNTING[] State;
    }
}