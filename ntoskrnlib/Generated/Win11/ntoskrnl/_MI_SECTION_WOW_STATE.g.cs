#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_SECTION_WOW_STATE
    {
        [FieldOffset(0)]
        public _RTL_BITMAP_EX ImageBitMap;
        [FieldOffset(16)]
        public _MI_DLL_OVERFLOW_AREA OverflowArea;
        [FieldOffset(48)]
        public IntPtr CfgBitMapSection;
        [FieldOffset(56)]
        public IntPtr CfgBitMapControlArea;
    }
}