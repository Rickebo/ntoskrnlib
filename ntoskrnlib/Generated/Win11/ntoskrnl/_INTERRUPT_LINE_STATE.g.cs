#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _INTERRUPT_LINE_STATE
    {
        [FieldOffset(0)]
        public uint Polarity;
        [FieldOffset(4)]
        public byte EmulateActiveBoth;
        [FieldOffset(8)]
        public uint TriggerMode;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public _INTERRUPT_LINE Routing;
        [FieldOffset(24)]
        public _INTERRUPT_TARGET ProcessorTarget;
        [FieldOffset(48)]
        public uint Vector;
        [FieldOffset(52)]
        public uint Priority;
    }
}