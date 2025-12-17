#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _POP_FX_IDLE_STATE
    {
        [FieldOffset(0)]
        public ulong TransitionLatency;
        [FieldOffset(8)]
        public ulong ResidencyRequirement;
        [FieldOffset(16)]
        public uint NominalPower;
    }
}