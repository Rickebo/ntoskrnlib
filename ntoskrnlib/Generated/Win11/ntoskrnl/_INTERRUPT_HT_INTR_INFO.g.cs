#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _INTERRUPT_HT_INTR_INFO
    {
        [FieldOffset(0)]
        public _unnamed_tag_ LowPart;
        [FieldOffset(4)]
        public _unnamed_tag_ HighPart;
    }
}