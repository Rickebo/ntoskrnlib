#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial struct _DESCRIPTION_HEADER
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint Length;
        [FieldOffset(8)]
        public byte Revision;
        [FieldOffset(9)]
        public byte Checksum;
        [FieldOffset(10)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public sbyte[] OEMID;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public sbyte[] OEMTableID;
        [FieldOffset(24)]
        public uint OEMRevision;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public sbyte[] CreatorID;
        [FieldOffset(32)]
        public uint CreatorRev;
    }
}