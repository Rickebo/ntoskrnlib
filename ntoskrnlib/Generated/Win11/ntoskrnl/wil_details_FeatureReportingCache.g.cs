#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct wil_details_FeatureReportingCache
    {
        [FieldOffset(0)]
        public wil_details_ReportedState reported;
        [FieldOffset(4)]
        public wil_details_RecordedState recorded;
    }
}