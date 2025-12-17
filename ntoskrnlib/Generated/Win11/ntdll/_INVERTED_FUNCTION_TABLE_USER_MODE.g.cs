#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12304)]
    public partial struct _INVERTED_FUNCTION_TABLE_USER_MODE
    {
        [FieldOffset(0)]
        public uint CurrentSize;
        [FieldOffset(4)]
        public uint MaximumSize;
        [FieldOffset(8)]
        public uint Epoch;
        [FieldOffset(12)]
        public byte Overflow;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public _INVERTED_FUNCTION_TABLE_ENTRY[] TableEntry;
    }
}