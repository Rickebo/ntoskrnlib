#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _KTIMER
    {
        [FieldOffset(0)]
        public _DISPATCHER_HEADER Header;
        [FieldOffset(24)]
        public _ULARGE_INTEGER DueTime;
        [FieldOffset(32)]
        public _LIST_ENTRY TimerListEntry;
        [FieldOffset(48)]
        public IntPtr Dpc;
        [FieldOffset(56)]
        public ushort Processor;
        [FieldOffset(58)]
        public ushort TimerType;
        [FieldOffset(60)]
        public uint Period;
    }
}