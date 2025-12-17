#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _PROC_FEEDBACK_COUNTER
    {
        [FieldOffset(0)]
        public IntPtr InstantaneousRead;
        [FieldOffset(0)]
        public IntPtr DifferentialRead;
        [FieldOffset(8)]
        public ulong LastActualCount;
        [FieldOffset(16)]
        public ulong LastReferenceCount;
        [FieldOffset(24)]
        public uint CachedValue;
        [FieldOffset(32)]
        public byte Affinitized;
        [FieldOffset(33)]
        public byte Differential;
        [FieldOffset(34)]
        public byte DiscardIdleTime;
        [FieldOffset(36)]
        public uint Scaling;
        [FieldOffset(40)]
        public ulong Context;
    }
}