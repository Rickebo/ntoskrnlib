#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _EVENT_HEADER
    {
        [FieldOffset(0)]
        public ushort Size;
        [FieldOffset(2)]
        public ushort HeaderType;
        [FieldOffset(4)]
        public ushort Flags;
        [FieldOffset(6)]
        public ushort EventProperty;
        [FieldOffset(8)]
        public uint ThreadId;
        [FieldOffset(12)]
        public uint ProcessId;
        [FieldOffset(16)]
        public _LARGE_INTEGER TimeStamp;
        [FieldOffset(24)]
        public _GUID ProviderId;
        [FieldOffset(40)]
        public _EVENT_DESCRIPTOR EventDescriptor;
        [FieldOffset(56)]
        public uint KernelTime;
        [FieldOffset(60)]
        public uint UserTime;
        [FieldOffset(56)]
        public ulong ProcessorTime;
        [FieldOffset(64)]
        public _GUID ActivityId;
    }
}