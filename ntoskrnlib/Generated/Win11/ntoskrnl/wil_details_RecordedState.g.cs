#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct wil_details_RecordedState
    {
        [FieldOffset(0)]
        public uint exchange;
        [FieldOffset(0)]
        public uint recordedDeviceUsage;
        [FieldOffset(0)]
        public uint recordedDevicePotential;
        [FieldOffset(0)]
        public uint recordedDeviceOpportunity;
        [FieldOffset(0)]
        public uint recordedDevicePotentialOpportunity;
        [FieldOffset(0)]
        public uint recordedVariantDeviceUsage;
        [FieldOffset(0)]
        public uint recordedVariant;
        [FieldOffset(0)]
        public uint unused;
    }
}