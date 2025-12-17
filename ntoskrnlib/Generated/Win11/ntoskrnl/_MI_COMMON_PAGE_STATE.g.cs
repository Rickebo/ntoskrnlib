#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _MI_COMMON_PAGE_STATE
    {
        [FieldOffset(0)]
        public IntPtr DummyPagePfn;
        [FieldOffset(8)]
        public ulong DummyPage;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _MI_FILLED_COMMON_PAGE_STATE[] GapFrames;
    }
}