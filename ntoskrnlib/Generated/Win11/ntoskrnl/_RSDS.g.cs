#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _RSDS
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public _GUID Guid;
        [FieldOffset(20)]
        public uint Age;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public sbyte[] PdbName;
    }
}