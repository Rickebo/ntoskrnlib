#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _HEAP_LOCAL_DATA
    {
        [FieldOffset(0)]
        public _SLIST_HEADER DeletedSubSegments;
        [FieldOffset(16)]
        public IntPtr CrtZone;
        [FieldOffset(24)]
        public IntPtr LowFragHeap;
        [FieldOffset(32)]
        public uint Sequence;
        [FieldOffset(36)]
        public uint DeleteRateThreshold;
    }
}