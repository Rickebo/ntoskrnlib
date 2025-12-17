#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _WHEA_GENERIC_ERROR_DESCRIPTOR_V2
    {
        [FieldOffset(0)]
        public ushort Type;
        [FieldOffset(2)]
        public byte Reserved;
        [FieldOffset(3)]
        public byte Enabled;
        [FieldOffset(4)]
        public uint ErrStatusBlockLength;
        [FieldOffset(8)]
        public uint RelatedErrorSourceId;
        [FieldOffset(12)]
        public byte ErrStatusAddressSpaceID;
        [FieldOffset(13)]
        public byte ErrStatusAddressBitWidth;
        [FieldOffset(14)]
        public byte ErrStatusAddressBitOffset;
        [FieldOffset(15)]
        public byte ErrStatusAddressAccessSize;
        [FieldOffset(16)]
        public _LARGE_INTEGER ErrStatusAddress;
        [FieldOffset(24)]
        public _WHEA_NOTIFICATION_DESCRIPTOR Notify;
        [FieldOffset(52)]
        public byte ReadAckAddressSpaceID;
        [FieldOffset(53)]
        public byte ReadAckAddressBitWidth;
        [FieldOffset(54)]
        public byte ReadAckAddressBitOffset;
        [FieldOffset(55)]
        public byte ReadAckAddressAccessSize;
        [FieldOffset(56)]
        public _LARGE_INTEGER ReadAckAddress;
        [FieldOffset(64)]
        public ulong ReadAckPreserveMask;
        [FieldOffset(72)]
        public ulong ReadAckWriteMask;
    }
}