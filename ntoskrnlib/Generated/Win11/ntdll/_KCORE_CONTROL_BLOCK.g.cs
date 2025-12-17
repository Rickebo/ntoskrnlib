#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _KCORE_CONTROL_BLOCK
    {
        [FieldOffset(0)]
        public byte ProcessorCount;
        [FieldOffset(1)]
        public byte ScanStartIndex;
        [FieldOffset(2)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] Spare;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] Prcbs;
        [FieldOffset(40)]
        public IntPtr CoreControlBlockShadow;
    }
}