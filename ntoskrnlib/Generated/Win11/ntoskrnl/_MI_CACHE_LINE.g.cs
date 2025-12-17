#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_CACHE_LINE
    {
        [FieldOffset(0)]
        public _unnamed_tag_ u1;
        [FieldOffset(0)]
        public _unnamed_tag_ u2;
    }
}