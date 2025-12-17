#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 6160)]
    public partial struct _INVERTED_FUNCTION_TABLE_KERNEL_MODE
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
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public _INVERTED_FUNCTION_TABLE_ENTRY[] TableEntry;
    }
}