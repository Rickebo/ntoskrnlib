#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 632)]
    public partial struct _DUAL
    {
        [FieldOffset(0)]
        public uint Length;
        [FieldOffset(8)]
        public IntPtr Map;
        [FieldOffset(16)]
        public IntPtr SmallDir;
        [FieldOffset(24)]
        public uint Guard;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public _FREE_DISPLAY[] FreeDisplay;
        [FieldOffset(608)]
        public _LIST_ENTRY FreeBins;
        [FieldOffset(624)]
        public uint FreeSummary;
    }
}