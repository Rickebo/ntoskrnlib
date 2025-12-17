#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _INTERRUPT_LINE_INTERNAL_STATE
    {
        [FieldOffset(0)]
        public byte Fixed;
        [FieldOffset(1)]
        public byte Irql;
        [FieldOffset(2)]
        public byte Swapping;
        [FieldOffset(4)]
        public uint OldClusterId;
        [FieldOffset(8)]
        public uint OldClusterMask;
        [FieldOffset(12)]
        public byte LineStateDetermined;
    }
}