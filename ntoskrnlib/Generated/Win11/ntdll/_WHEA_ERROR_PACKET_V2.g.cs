#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _WHEA_ERROR_PACKET_V2
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint Version;
        [FieldOffset(8)]
        public uint Length;
        [FieldOffset(12)]
        public _WHEA_ERROR_PACKET_FLAGS Flags;
        [FieldOffset(16)]
        public uint ErrorType;
        [FieldOffset(20)]
        public uint ErrorSeverity;
        [FieldOffset(24)]
        public uint ErrorSourceId;
        [FieldOffset(28)]
        public uint ErrorSourceType;
        [FieldOffset(32)]
        public _GUID NotifyType;
        [FieldOffset(48)]
        public ulong Context;
        [FieldOffset(56)]
        public uint DataFormat;
        [FieldOffset(60)]
        public uint Reserved1;
        [FieldOffset(64)]
        public uint DataOffset;
        [FieldOffset(68)]
        public uint DataLength;
        [FieldOffset(72)]
        public uint PshedDataOffset;
        [FieldOffset(76)]
        public uint PshedDataLength;
    }
}