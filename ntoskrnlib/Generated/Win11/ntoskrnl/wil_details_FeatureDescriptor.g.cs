#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct wil_details_FeatureDescriptor
    {
        [FieldOffset(0)]
        public IntPtr featureStateCache;
        [FieldOffset(8)]
        public IntPtr featureReportingCache;
        [FieldOffset(16)]
        public IntPtr featureLoggedTraits;
        [FieldOffset(24)]
        public uint featureId;
        [FieldOffset(28)]
        public byte changeTime;
        [FieldOffset(29)]
        public byte isAlwaysDisabled;
        [FieldOffset(30)]
        public byte isAlwaysEnabled;
        [FieldOffset(31)]
        public byte isEnabledByDefault;
        [FieldOffset(32)]
        public IntPtr requiresFeatures;
        [FieldOffset(40)]
        public byte variant;
        [FieldOffset(44)]
        public uint payloadKind;
        [FieldOffset(48)]
        public uint payload;
    }
}