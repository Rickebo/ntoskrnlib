#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _RTL_FEATURE_CONFIGURATION
    {
        [FieldOffset(0)]
        public uint FeatureId;
        [FieldOffset(4)]
        public uint Priority;
        [FieldOffset(4)]
        public uint EnabledState;
        [FieldOffset(4)]
        public uint IsWexpConfiguration;
        [FieldOffset(4)]
        public uint HasSubscriptions;
        [FieldOffset(4)]
        public uint Variant;
        [FieldOffset(4)]
        public uint VariantPayloadKind;
        [FieldOffset(8)]
        public uint VariantPayload;
    }
}