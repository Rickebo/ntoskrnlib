#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _SMBIOS3_TABLE_HEADER
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public byte[] Signature;
        [FieldOffset(5)]
        public byte Checksum;
        [FieldOffset(6)]
        public byte Length;
        [FieldOffset(7)]
        public byte MajorVersion;
        [FieldOffset(8)]
        public byte MinorVersion;
        [FieldOffset(9)]
        public byte Docrev;
        [FieldOffset(10)]
        public byte EntryPointRevision;
        [FieldOffset(11)]
        public byte Reserved;
        [FieldOffset(12)]
        public uint StructureTableMaximumSize;
        [FieldOffset(16)]
        public ulong StructureTableAddress;
    }
}