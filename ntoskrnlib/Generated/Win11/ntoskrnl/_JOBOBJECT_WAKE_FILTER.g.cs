#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _JOBOBJECT_WAKE_FILTER
    {
        [FieldOffset(0)]
        public uint HighEdgeFilter;
        [FieldOffset(4)]
        public uint LowEdgeFilter;
    }
}