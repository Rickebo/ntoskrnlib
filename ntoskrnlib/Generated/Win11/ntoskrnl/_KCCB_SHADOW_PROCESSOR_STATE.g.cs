#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _KCCB_SHADOW_PROCESSOR_STATE
    {
        [FieldOffset(0)]
        public byte Idle;
        [FieldOffset(0)]
        public byte Transitioning;
        [FieldOffset(0)]
        public byte AllState;
    }
}