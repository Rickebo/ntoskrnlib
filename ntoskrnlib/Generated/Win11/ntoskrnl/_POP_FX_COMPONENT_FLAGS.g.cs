#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _POP_FX_COMPONENT_FLAGS
    {
        [FieldOffset(0)]
        public int Value;
        [FieldOffset(4)]
        public int Value2;
        [FieldOffset(0)]
        public uint RefCount;
        [FieldOffset(0)]
        public uint Idling;
        [FieldOffset(0)]
        public uint Active;
        [FieldOffset(4)]
        public uint CriticalIdleOverride;
        [FieldOffset(4)]
        public uint ResidentOverride;
        [FieldOffset(4)]
        public uint Reserved;
    }
}