#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _PEBS_DS_SAVE_AREA32
    {
        [FieldOffset(0)]
        public uint BtsBufferBase;
        [FieldOffset(4)]
        public uint BtsIndex;
        [FieldOffset(8)]
        public uint BtsAbsoluteMaximum;
        [FieldOffset(12)]
        public uint BtsInterruptThreshold;
        [FieldOffset(16)]
        public uint PebsBufferBase;
        [FieldOffset(20)]
        public uint PebsIndex;
        [FieldOffset(24)]
        public uint PebsAbsoluteMaximum;
        [FieldOffset(28)]
        public uint PebsInterruptThreshold;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] PebsGpCounterReset;
        [FieldOffset(96)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] PebsFixedCounterReset;
    }
}