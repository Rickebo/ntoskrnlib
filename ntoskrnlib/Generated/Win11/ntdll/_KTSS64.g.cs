#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _KTSS64
    {
        [FieldOffset(0)]
        public uint Reserved0;
        [FieldOffset(4)]
        public ulong Rsp0;
        [FieldOffset(12)]
        public ulong Rsp1;
        [FieldOffset(20)]
        public ulong Rsp2;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ulong[] Ist;
        [FieldOffset(92)]
        public ulong Reserved1;
        [FieldOffset(100)]
        public ushort Reserved2;
        [FieldOffset(102)]
        public ushort IoMapBase;
    }
}