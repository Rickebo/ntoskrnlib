#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _PEP_ACPI_EXTENDED_ADDRESS
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public _PEP_ACPI_RESOURCE_FLAGS Flags;
        [FieldOffset(8)]
        public byte ResourceFlags;
        [FieldOffset(9)]
        public byte GeneralFlags;
        [FieldOffset(10)]
        public byte TypeSpecificFlags;
        [FieldOffset(11)]
        public byte RevisionId;
        [FieldOffset(12)]
        public byte Reserved;
        [FieldOffset(16)]
        public ulong Granularity;
        [FieldOffset(24)]
        public ulong MinimumAddress;
        [FieldOffset(32)]
        public ulong MaximumAddress;
        [FieldOffset(40)]
        public ulong TranslationAddress;
        [FieldOffset(48)]
        public ulong AddressLength;
        [FieldOffset(56)]
        public ulong TypeAttribute;
        [FieldOffset(64)]
        public IntPtr DescriptorName;
    }
}