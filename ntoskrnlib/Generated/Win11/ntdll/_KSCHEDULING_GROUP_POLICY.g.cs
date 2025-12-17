#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KSCHEDULING_GROUP_POLICY
    {
        [FieldOffset(0)]
        public uint Value;
        [FieldOffset(0)]
        public ushort Weight;
        [FieldOffset(0)]
        public ushort MinRate;
        [FieldOffset(2)]
        public ushort MaxRate;
        [FieldOffset(4)]
        public uint AllFlags;
        [FieldOffset(4)]
        public uint Type;
        [FieldOffset(4)]
        public uint Disabled;
        [FieldOffset(4)]
        public uint RankBias;
        [FieldOffset(4)]
        public uint PerProcessorLimits;
        [FieldOffset(4)]
        public uint Spare1;
    }
}