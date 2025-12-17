#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _RTLP_HP_ALLOC_TRACKER
    {
        [FieldOffset(0)]
        public ulong BaseAddress;
        [FieldOffset(8)]
        public _RTL_CSPARSE_BITMAP AllocTrackerBitmap;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        public byte[] AllocTrackerBitmapBuffer;
    }
}