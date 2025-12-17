#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct wil_FeatureState
    {
        [FieldOffset(0)]
        public uint enabledState;
        [FieldOffset(4)]
        public byte variant;
        [FieldOffset(8)]
        public uint payloadKind;
        [FieldOffset(12)]
        public uint payload;
        [FieldOffset(16)]
        public int hasNotification;
        [FieldOffset(20)]
        public int isWexpConfiguration;
    }
}