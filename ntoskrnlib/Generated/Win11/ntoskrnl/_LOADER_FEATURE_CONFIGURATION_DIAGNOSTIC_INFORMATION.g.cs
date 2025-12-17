#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION
    {
        [FieldOffset(0)]
        public byte OriginalBootStatus;
        [FieldOffset(1)]
        public byte NewBootStatus;
        [FieldOffset(2)]
        public byte ConfigurationLoaded;
        [FieldOffset(3)]
        public byte Spare;
        [FieldOffset(4)]
        public _unnamed_tag_ Flags;
        [FieldOffset(8)]
        public int ConfigurationComparisonStatus;
        [FieldOffset(12)]
        public int CurrentConfigurationLoadStatus;
        [FieldOffset(16)]
        public int LkgConfigurationLoadStatus;
        [FieldOffset(20)]
        public int UsageSubscriptionLoadStatus;
    }
}