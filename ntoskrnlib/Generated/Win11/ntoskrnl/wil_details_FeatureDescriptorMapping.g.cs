#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct wil_details_FeatureDescriptorMapping
    {
        [FieldOffset(0)]
        public uint featureId;
        [FieldOffset(8)]
        public IntPtr descriptor;
    }
}