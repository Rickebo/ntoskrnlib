#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _FSRTL_COMMON_FCB_HEADER
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeByteSize;
        [FieldOffset(4)]
        public byte Flags;
        [FieldOffset(5)]
        public byte IsFastIoPossible;
        [FieldOffset(6)]
        public byte Flags2;
        [FieldOffset(7)]
        public byte Reserved;
        [FieldOffset(7)]
        public byte Version;
        [FieldOffset(8)]
        public IntPtr Resource;
        [FieldOffset(16)]
        public IntPtr PagingIoResource;
        [FieldOffset(24)]
        public _LARGE_INTEGER AllocationSize;
        [FieldOffset(32)]
        public _LARGE_INTEGER FileSize;
        [FieldOffset(40)]
        public _LARGE_INTEGER ValidDataLength;
    }
}