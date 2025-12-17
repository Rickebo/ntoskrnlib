#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _ETW_PAYLOAD_FILTER
    {
        [FieldOffset(0)]
        public int RefCount;
        [FieldOffset(8)]
        public _AGGREGATED_PAYLOAD_FILTER PayloadFilter;
    }
}