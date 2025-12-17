#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct PROCESSOR_PERFSTATE_POLICY
    {
        [FieldOffset(0)]
        public uint Revision;
        [FieldOffset(4)]
        public byte MaxThrottle;
        [FieldOffset(5)]
        public byte MinThrottle;
        [FieldOffset(6)]
        public byte BusyAdjThreshold;
        [FieldOffset(7)]
        public byte Spare;
        [FieldOffset(7)]
        public _unnamed_tag_ Flags;
        [FieldOffset(8)]
        public uint TimeCheck;
        [FieldOffset(12)]
        public uint IncreaseTime;
        [FieldOffset(16)]
        public uint DecreaseTime;
        [FieldOffset(20)]
        public uint IncreasePercent;
        [FieldOffset(24)]
        public uint DecreasePercent;
    }
}