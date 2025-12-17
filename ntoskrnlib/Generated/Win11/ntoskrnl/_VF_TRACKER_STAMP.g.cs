#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _VF_TRACKER_STAMP
    {
        [FieldOffset(0)]
        public IntPtr Thread;
        [FieldOffset(8)]
        public byte Flags;
        [FieldOffset(9)]
        public byte OldIrql;
        [FieldOffset(10)]
        public byte NewIrql;
        [FieldOffset(11)]
        public byte Processor;
    }
}