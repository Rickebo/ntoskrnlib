#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _RTL_RANGE
    {
        [FieldOffset(0)]
        public ulong Start;
        [FieldOffset(8)]
        public ulong End;
        [FieldOffset(16)]
        public IntPtr UserData;
        [FieldOffset(24)]
        public IntPtr Owner;
        [FieldOffset(32)]
        public byte Attributes;
        [FieldOffset(33)]
        public byte Flags;
    }
}