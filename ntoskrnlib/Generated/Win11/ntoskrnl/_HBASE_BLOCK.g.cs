#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4096)]
    public partial struct _HBASE_BLOCK
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint Sequence1;
        [FieldOffset(8)]
        public uint Sequence2;
        [FieldOffset(12)]
        public _LARGE_INTEGER TimeStamp;
        [FieldOffset(20)]
        public uint Major;
        [FieldOffset(24)]
        public uint Minor;
        [FieldOffset(28)]
        public uint Type;
        [FieldOffset(32)]
        public uint Format;
        [FieldOffset(36)]
        public uint RootCell;
        [FieldOffset(40)]
        public uint Length;
        [FieldOffset(44)]
        public uint Cluster;
        [FieldOffset(48)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] FileName;
        [FieldOffset(112)]
        public _GUID RmId;
        [FieldOffset(128)]
        public _GUID LogId;
        [FieldOffset(144)]
        public uint Flags;
        [FieldOffset(148)]
        public _GUID TmId;
        [FieldOffset(164)]
        public uint GuidSignature;
        [FieldOffset(168)]
        public ulong LastReorganizeTime;
        [FieldOffset(176)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 83)]
        public uint[] Reserved1;
        [FieldOffset(508)]
        public uint CheckSum;
        [FieldOffset(512)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 882)]
        public uint[] Reserved2;
        [FieldOffset(4040)]
        public _GUID ThawTmId;
        [FieldOffset(4056)]
        public _GUID ThawRmId;
        [FieldOffset(4072)]
        public _GUID ThawLogId;
        [FieldOffset(4088)]
        public uint BootType;
        [FieldOffset(4092)]
        public uint BootRecover;
    }
}