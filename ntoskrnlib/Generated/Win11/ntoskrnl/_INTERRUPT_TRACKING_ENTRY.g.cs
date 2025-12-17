#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial struct _INTERRUPT_TRACKING_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr IntTrackRoot;
        [FieldOffset(24)]
        public uint InterruptObjectCount;
        [FieldOffset(32)]
        public IntPtr InterruptObjectArray;
        [FieldOffset(40)]
        public ulong IsrTime;
        [FieldOffset(48)]
        public ulong DpcTime;
        [FieldOffset(56)]
        public byte IsPrimaryInterrupt;
        [FieldOffset(64)]
        public _INTERRUPT_VECTOR_DATA VectorData;
    }
}