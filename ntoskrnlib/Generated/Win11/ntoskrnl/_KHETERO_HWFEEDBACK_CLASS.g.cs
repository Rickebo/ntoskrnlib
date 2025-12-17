#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _KHETERO_HWFEEDBACK_CLASS
    {
        [FieldOffset(0)]
        public byte PerformanceClass;
        [FieldOffset(1)]
        public byte EfficiencyClass;
        [FieldOffset(2)]
        public byte PerformanceClassRawValue;
        [FieldOffset(3)]
        public byte EfficiencyClassRawValue;
    }
}