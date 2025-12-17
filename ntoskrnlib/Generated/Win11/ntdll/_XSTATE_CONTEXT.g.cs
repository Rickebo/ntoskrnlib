#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _XSTATE_CONTEXT
    {
        [FieldOffset(0)]
        public ulong Mask;
        [FieldOffset(8)]
        public uint Length;
        [FieldOffset(12)]
        public byte Flags;
        [FieldOffset(13)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Reserved0;
        [FieldOffset(16)]
        public IntPtr Area;
        [FieldOffset(24)]
        public IntPtr Buffer;
    }
}