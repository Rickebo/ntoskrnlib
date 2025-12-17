#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _MI_PARTITION_COMMIT
    {
        [FieldOffset(0)]
        public ulong PeakCommitment;
        [FieldOffset(8)]
        public ulong TotalCommitLimitMaximum;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Popups;
        [FieldOffset(24)]
        public ulong LowCommitThreshold;
        [FieldOffset(32)]
        public ulong HighCommitThreshold;
        [FieldOffset(40)]
        public ulong ExtremelyHighCommitThreshold;
        [FieldOffset(48)]
        public ulong IdealCommitTarget;
        [FieldOffset(56)]
        public int Lock;
        [FieldOffset(64)]
        public ulong SystemCommitReserve;
        [FieldOffset(72)]
        public ulong OverCommit;
    }
}