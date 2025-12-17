#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _NB10
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint Offset;
        [FieldOffset(8)]
        public uint TimeStamp;
        [FieldOffset(12)]
        public uint Age;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public sbyte[] PdbName;
    }
}