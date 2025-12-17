#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct wil_details_RecordUsageResult
    {
        [FieldOffset(0)]
        public int queueBackground;
        [FieldOffset(4)]
        public uint countImmediate;
        [FieldOffset(8)]
        public uint kindImmediate;
        [FieldOffset(12)]
        public uint payloadId;
        [FieldOffset(16)]
        public int ignoredUse;
        [FieldOffset(20)]
        public int isWexpConfiguration;
    }
}