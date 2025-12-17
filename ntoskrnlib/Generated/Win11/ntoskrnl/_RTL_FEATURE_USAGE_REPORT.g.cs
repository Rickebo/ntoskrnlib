#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _RTL_FEATURE_USAGE_REPORT
    {
        [FieldOffset(0)]
        public uint FeatureId;
        [FieldOffset(4)]
        public ushort ReportingKind;
        [FieldOffset(6)]
        public ushort ReportingOptions;
    }
}