#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _PERF_CONTROL_STATE_SELECTION
    {
        [FieldOffset(0)]
        public ulong SelectedState;
        [FieldOffset(8)]
        public ulong SelectedResourcePriority;
        [FieldOffset(16)]
        public uint SelectedPercent;
        [FieldOffset(20)]
        public uint SelectedFrequency;
        [FieldOffset(24)]
        public uint MinPercent;
        [FieldOffset(28)]
        public uint MaxPercent;
        [FieldOffset(32)]
        public uint TolerancePercent;
        [FieldOffset(36)]
        public uint EppPercent;
        [FieldOffset(40)]
        public uint AutonomousActivityWindow;
        [FieldOffset(44)]
        public uint ResourcePriorityPercent;
        [FieldOffset(48)]
        public byte Autonomous;
        [FieldOffset(49)]
        public byte InheritFromDomain;
    }
}