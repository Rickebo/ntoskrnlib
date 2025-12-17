#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _XPF_MCE_FLAGS
    {
        [FieldOffset(0)]
        public uint MCG_CapabilityRW;
        [FieldOffset(0)]
        public uint MCG_GlobalControlRW;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}