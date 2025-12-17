#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MMSUPPORT_AGGREGATION
    {
        [FieldOffset(0)]
        public uint PageFaultCount;
        [FieldOffset(8)]
        public ulong WorkingSetSize;
        [FieldOffset(16)]
        public ulong WorkingSetLeafSize;
        [FieldOffset(24)]
        public ulong PeakWorkingSetSize;
    }
}