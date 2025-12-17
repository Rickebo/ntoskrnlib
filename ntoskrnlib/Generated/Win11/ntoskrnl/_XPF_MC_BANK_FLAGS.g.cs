#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _XPF_MC_BANK_FLAGS
    {
        [FieldOffset(0)]
        public byte ClearOnInitializationRW;
        [FieldOffset(0)]
        public byte ControlDataRW;
        [FieldOffset(0)]
        public byte Reserved;
        [FieldOffset(0)]
        public byte AsUCHAR;
    }
}