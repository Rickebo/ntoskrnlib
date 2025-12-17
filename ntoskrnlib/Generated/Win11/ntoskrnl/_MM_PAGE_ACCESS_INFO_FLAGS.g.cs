#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MM_PAGE_ACCESS_INFO_FLAGS
    {
        [FieldOffset(0)]
        public _unnamed_tag_ File;
        [FieldOffset(0)]
        public _unnamed_tag_ Private;
    }
}