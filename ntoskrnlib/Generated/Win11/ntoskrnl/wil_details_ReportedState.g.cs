#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct wil_details_ReportedState
    {
        [FieldOffset(0)]
        public uint exchange;
        [FieldOffset(0)]
        public uint queuedForReporting;
        [FieldOffset(0)]
        public uint reportedDeviceUsage;
        [FieldOffset(0)]
        public uint reportedDevicePotential;
        [FieldOffset(0)]
        public uint reportedDeviceOpportunity;
        [FieldOffset(0)]
        public uint reportedDevicePotentialOpportunity;
        [FieldOffset(0)]
        public uint usageCount;
        [FieldOffset(0)]
        public uint usageCountRepresentsPotential;
        [FieldOffset(0)]
        public uint opportunityCount;
        [FieldOffset(0)]
        public uint opportunityCountRepresentsPotential;
        [FieldOffset(0)]
        public uint unused;
    }
}