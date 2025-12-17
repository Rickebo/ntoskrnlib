#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _HAL_CLOCK_TIMER_CONFIGURATION
    {
        [FieldOffset(0)]
        public byte Flags;
        [FieldOffset(0)]
        public byte AlwaysOnTimer;
        [FieldOffset(0)]
        public byte HighLatency;
        [FieldOffset(0)]
        public byte PerCpuTimer;
        [FieldOffset(0)]
        public byte DynamicTickSupported;
        [FieldOffset(4)]
        public uint KnownType;
        [FieldOffset(8)]
        public uint Capabilities;
        [FieldOffset(16)]
        public ulong MaxIncrement;
        [FieldOffset(24)]
        public uint MinIncrement;
    }
}