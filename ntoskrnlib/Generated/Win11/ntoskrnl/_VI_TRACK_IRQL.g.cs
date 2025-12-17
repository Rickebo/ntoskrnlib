#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _VI_TRACK_IRQL
    {
        [FieldOffset(0)]
        public IntPtr Thread;
        [FieldOffset(8)]
        public byte OldIrql;
        [FieldOffset(9)]
        public byte NewIrql;
        [FieldOffset(10)]
        public ushort Processor;
        [FieldOffset(12)]
        public uint TickCount;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public IntPtr[] StackTrace;
    }
}