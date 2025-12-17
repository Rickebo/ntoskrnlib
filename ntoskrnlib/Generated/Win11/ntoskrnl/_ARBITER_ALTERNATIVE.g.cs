#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _ARBITER_ALTERNATIVE
    {
        [FieldOffset(0)]
        public ulong Minimum;
        [FieldOffset(8)]
        public ulong Maximum;
        [FieldOffset(16)]
        public ulong Length;
        [FieldOffset(24)]
        public ulong Alignment;
        [FieldOffset(32)]
        public int Priority;
        [FieldOffset(36)]
        public uint Flags;
        [FieldOffset(40)]
        public IntPtr Descriptor;
        [FieldOffset(48)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] Reserved;
    }
}