#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR
    {
        [FieldOffset(0)]
        public uint SectionOffset;
        [FieldOffset(4)]
        public uint SectionLength;
        [FieldOffset(8)]
        public _WHEA_REVISION Revision;
        [FieldOffset(10)]
        public _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS ValidBits;
        [FieldOffset(11)]
        public byte Reserved;
        [FieldOffset(12)]
        public _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS Flags;
        [FieldOffset(16)]
        public _GUID SectionType;
        [FieldOffset(32)]
        public _GUID FRUId;
        [FieldOffset(48)]
        public uint SectionSeverity;
        [FieldOffset(52)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public sbyte[] FRUText;
    }
}