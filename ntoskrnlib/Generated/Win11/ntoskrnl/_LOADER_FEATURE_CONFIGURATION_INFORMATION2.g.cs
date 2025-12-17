#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _LOADER_FEATURE_CONFIGURATION_INFORMATION2
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(8)]
        public IntPtr DelayedFeatureUsageDataBuffer;
        [FieldOffset(16)]
        public ulong DelayedFeatureUsageDataBufferSize;
        [FieldOffset(24)]
        public byte ExperimentationClientPresent;
        [FieldOffset(32)]
        public IntPtr GovernedFeatureInfoTable;
        [FieldOffset(40)]
        public ulong GovernedFeatureInfoTableSize;
    }
}