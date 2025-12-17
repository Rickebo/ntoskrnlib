#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _WHEA_IN_USE_PAGE_NOTIFY_FLAGS
    {
        [FieldOffset(0)]
        public _unnamed_tag_ Bits;
        [FieldOffset(0)]
        public byte AsUCHAR;
    }
}