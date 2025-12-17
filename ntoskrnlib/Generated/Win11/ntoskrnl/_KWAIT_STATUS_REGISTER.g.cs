#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _KWAIT_STATUS_REGISTER
    {
        [FieldOffset(0)]
        public byte Flags;
        [FieldOffset(0)]
        public byte State;
        [FieldOffset(0)]
        public byte Affinity;
        [FieldOffset(0)]
        public byte Priority;
        [FieldOffset(0)]
        public byte Apc;
        [FieldOffset(0)]
        public byte UserApc;
        [FieldOffset(0)]
        public byte Alert;
    }
}