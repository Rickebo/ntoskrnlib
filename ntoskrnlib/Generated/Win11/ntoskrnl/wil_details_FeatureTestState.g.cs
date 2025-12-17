#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct wil_details_FeatureTestState
    {
        [FieldOffset(0)]
        public uint kind;
        [FieldOffset(4)]
        public uint featureId;
        [FieldOffset(8)]
        public uint state;
        [FieldOffset(12)]
        public byte variant;
        [FieldOffset(16)]
        public uint payload;
        [FieldOffset(20)]
        public uint payloadKind;
        [FieldOffset(24)]
        public IntPtr next;
    }
}