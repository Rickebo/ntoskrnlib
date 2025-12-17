#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_CROSS_PARTITION_CHARGES
    {
        [FieldOffset(0)]
        public ulong CurrentCharges;
        [FieldOffset(8)]
        public ulong ChargeFailures;
        [FieldOffset(16)]
        public ulong ChargePeak;
        [FieldOffset(24)]
        public ulong MaximumAllowed;
    }
}