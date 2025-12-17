#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _PPM_PERF_SNAPSHOT
    {
        [FieldOffset(0)]
        public uint Initiator;
        [FieldOffset(4)]
        public byte LogType;
        [FieldOffset(5)]
        public byte Reset;
        [FieldOffset(6)]
        public byte Remote;
        [FieldOffset(8)]
        public ulong InterruptTime;
        [FieldOffset(16)]
        public ulong RawUnscaledTime;
        [FieldOffset(24)]
        public ulong TotalUnscaleTime;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] CachedScalingFactor;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] RawReferenceCount;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] RawActualCount;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] RawScaledTime;
        [FieldOffset(88)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] TotalScaleTime;
        [FieldOffset(104)]
        public ulong HvCurrentTime;
        [FieldOffset(112)]
        public ulong IdleAccumulation;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Value;
    }
}