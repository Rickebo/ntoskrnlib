#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _VF_TRACKER
    {
        [FieldOffset(0)]
        public uint TrackerFlags;
        [FieldOffset(4)]
        public uint TrackerSize;
        [FieldOffset(8)]
        public uint TrackerIndex;
        [FieldOffset(12)]
        public uint TraceDepth;
    }
}