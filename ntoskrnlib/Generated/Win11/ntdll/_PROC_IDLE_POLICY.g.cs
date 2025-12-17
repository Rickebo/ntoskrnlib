#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public partial struct _PROC_IDLE_POLICY
    {
        [FieldOffset(0)]
        public byte PromotePercent;
        [FieldOffset(1)]
        public byte DemotePercent;
        [FieldOffset(2)]
        public byte PromotePercentBase;
        [FieldOffset(3)]
        public byte DemotePercentBase;
        [FieldOffset(4)]
        public byte AllowScaling;
        [FieldOffset(5)]
        public byte ForceLightIdle;
    }
}