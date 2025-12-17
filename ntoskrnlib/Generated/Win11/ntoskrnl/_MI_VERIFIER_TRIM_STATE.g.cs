#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_VERIFIER_TRIM_STATE
    {
        [FieldOffset(0)]
        public ulong StartTime;
        [FieldOffset(8)]
        public ulong ActualTrimTime;
        [FieldOffset(16)]
        public ulong MaximumSingleTrimTimeReached;
        [FieldOffset(24)]
        public uint Instances;
        [FieldOffset(28)]
        public int TrimInProgress;
    }
}