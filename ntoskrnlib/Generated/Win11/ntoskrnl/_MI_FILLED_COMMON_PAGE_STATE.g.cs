#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_FILLED_COMMON_PAGE_STATE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] PageFrameIndex;
        [FieldOffset(32)]
        public IntPtr LeafMapping;
        [FieldOffset(40)]
        public ulong LeafCrc;
        [FieldOffset(48)]
        public _MMPTE PdeContents;
    }
}