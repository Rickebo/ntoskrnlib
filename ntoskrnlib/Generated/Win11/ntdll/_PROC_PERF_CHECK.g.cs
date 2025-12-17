#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1400)]
    public partial struct _PROC_PERF_CHECK
    {
        [FieldOffset(0)]
        public ulong LastActive;
        [FieldOffset(8)]
        public ulong LastTime;
        [FieldOffset(16)]
        public ulong LastStall;
        [FieldOffset(24)]
        public uint LastResponsivenessEvents;
        [FieldOffset(32)]
        public _PROC_PERF_CHECK_SNAP LastPerfCheckSnap;
        [FieldOffset(88)]
        public IntPtr LastPerfCheckCycleSnap;
        [FieldOffset(96)]
        public _PROC_PERF_CHECK_SNAP CurrentSnap;
        [FieldOffset(152)]
        public IntPtr CurrentCycleSnap;
        [FieldOffset(160)]
        public _PROC_PERF_CHECK_SNAP LastDeliveredSnap;
        [FieldOffset(216)]
        public IntPtr LastDeliveredCycleSnap;
        [FieldOffset(224)]
        public uint LastDeliveredPerformance;
        [FieldOffset(228)]
        public uint LastDeliveredFrequency;
        [FieldOffset(232)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] TaggedThreadPercent;
        [FieldOffset(236)]
        public byte ImportantPercent;
        [FieldOffset(237)]
        public byte IdealPercent;
        [FieldOffset(238)]
        public byte Class0FloorPerfSelection;
        [FieldOffset(239)]
        public byte Class1MinimumPerfSelection;
        [FieldOffset(240)]
        public uint CurrentResponsivenessEvents;
        [FieldOffset(248)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ulong[] CyclesByFreqBand;
    }
}