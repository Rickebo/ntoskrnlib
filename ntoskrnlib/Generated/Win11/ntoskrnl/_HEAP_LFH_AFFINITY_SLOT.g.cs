#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _HEAP_LFH_AFFINITY_SLOT
    {
        [FieldOffset(0)]
        public _HEAP_LFH_SUBSEGMENT_OWNER State;
        [FieldOffset(56)]
        public _HEAP_LFH_FAST_REF ActiveSubsegment;
    }
}