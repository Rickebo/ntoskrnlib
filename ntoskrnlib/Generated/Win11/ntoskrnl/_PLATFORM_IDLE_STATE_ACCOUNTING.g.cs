#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1024)]
    public partial struct _PLATFORM_IDLE_STATE_ACCOUNTING
    {
        [FieldOffset(0)]
        public uint CancelCount;
        [FieldOffset(4)]
        public uint FailureCount;
        [FieldOffset(8)]
        public uint SuccessCount;
        [FieldOffset(16)]
        public ulong MaxTime;
        [FieldOffset(24)]
        public ulong MinTime;
        [FieldOffset(32)]
        public ulong TotalTime;
        [FieldOffset(40)]
        public uint InvalidBucketIndex;
        [FieldOffset(48)]
        public _PPM_SELECTION_STATISTICS SelectionStatistics;
        [FieldOffset(192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public _PROC_IDLE_STATE_BUCKET[] IdleTimeBuckets;
    }
}