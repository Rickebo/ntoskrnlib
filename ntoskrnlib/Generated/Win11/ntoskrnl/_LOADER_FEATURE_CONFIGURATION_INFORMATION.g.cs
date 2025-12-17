#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _LOADER_FEATURE_CONFIGURATION_INFORMATION
    {
        [FieldOffset(0)]
        public IntPtr FeatureConfigurationBuffer;
        [FieldOffset(8)]
        public ulong FeatureConfigurationBufferSize;
        [FieldOffset(16)]
        public IntPtr UsageSubscriptionBuffer;
        [FieldOffset(24)]
        public ulong UsageSubscriptionBufferSize;
        [FieldOffset(32)]
        public IntPtr DelayedUsageReportBuffer;
        [FieldOffset(40)]
        public ulong DelayedUsageReportBufferSize;
        [FieldOffset(48)]
        public _LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION DiagnosticInformation;
    }
}