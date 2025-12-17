#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _KIST_LINK_FRAME
    {
        [FieldOffset(0)]
        public IntPtr IstBaseFrame;
        [FieldOffset(8)]
        public uint Signature;
        [FieldOffset(12)]
        public uint Reserved0;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] Reserved;
    }
}