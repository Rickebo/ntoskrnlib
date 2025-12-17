#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial struct _RSDP
    {
        [FieldOffset(0)]
        public ulong Signature;
        [FieldOffset(8)]
        public byte Checksum;
        [FieldOffset(9)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] OEMID;
        [FieldOffset(15)]
        public byte Revision;
        [FieldOffset(16)]
        public uint RsdtAddress;
        [FieldOffset(20)]
        public uint Length;
        [FieldOffset(24)]
        public _LARGE_INTEGER XsdtAddress;
        [FieldOffset(32)]
        public byte XChecksum;
        [FieldOffset(33)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Reserved;
    }
}