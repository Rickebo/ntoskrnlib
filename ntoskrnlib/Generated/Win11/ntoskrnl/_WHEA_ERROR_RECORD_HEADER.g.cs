#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _WHEA_ERROR_RECORD_HEADER
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public _WHEA_REVISION Revision;
        [FieldOffset(6)]
        public uint SignatureEnd;
        [FieldOffset(10)]
        public ushort SectionCount;
        [FieldOffset(12)]
        public uint Severity;
        [FieldOffset(16)]
        public _WHEA_ERROR_RECORD_HEADER_VALIDBITS ValidBits;
        [FieldOffset(20)]
        public uint Length;
        [FieldOffset(24)]
        public _WHEA_TIMESTAMP Timestamp;
        [FieldOffset(32)]
        public _GUID PlatformId;
        [FieldOffset(48)]
        public _GUID PartitionId;
        [FieldOffset(64)]
        public _GUID CreatorId;
        [FieldOffset(80)]
        public _GUID NotifyType;
        [FieldOffset(96)]
        public ulong RecordId;
        [FieldOffset(104)]
        public _WHEA_ERROR_RECORD_HEADER_FLAGS Flags;
        [FieldOffset(108)]
        public _WHEA_PERSISTENCE_INFO PersistenceInfo;
        [FieldOffset(116)]
        public uint OsBuildNumber;
        [FieldOffset(120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Reserved2;
        [FieldOffset(116)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] Reserved;
    }
}