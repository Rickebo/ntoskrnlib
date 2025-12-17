#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 576)]
    public partial struct _XSAVE_AREA
    {
        [FieldOffset(0)]
        public _XSAVE_FORMAT LegacyState;
        [FieldOffset(512)]
        public _XSAVE_AREA_HEADER Header;
    }
}