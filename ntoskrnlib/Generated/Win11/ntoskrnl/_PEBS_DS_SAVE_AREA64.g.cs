#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _PEBS_DS_SAVE_AREA64
    {
        [FieldOffset(0)]
        public ulong BtsBufferBase;
        [FieldOffset(8)]
        public ulong BtsIndex;
        [FieldOffset(16)]
        public ulong BtsAbsoluteMaximum;
        [FieldOffset(24)]
        public ulong BtsInterruptThreshold;
        [FieldOffset(32)]
        public ulong PebsBufferBase;
        [FieldOffset(40)]
        public ulong PebsIndex;
        [FieldOffset(48)]
        public ulong PebsAbsoluteMaximum;
        [FieldOffset(56)]
        public ulong PebsInterruptThreshold;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] PebsGpCounterReset;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] PebsFixedCounterReset;
    }
}