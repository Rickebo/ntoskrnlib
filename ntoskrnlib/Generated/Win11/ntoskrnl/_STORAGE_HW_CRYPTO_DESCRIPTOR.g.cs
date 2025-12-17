#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _STORAGE_HW_CRYPTO_DESCRIPTOR
    {
        [FieldOffset(0)]
        public _STORAGE_DESCRIPTOR_HEADER Header;
        [FieldOffset(8)]
        public uint NumKeysSupported;
        [FieldOffset(12)]
        public uint NumCryptoCapabilities;
        [FieldOffset(16)]
        public uint OffsetToCryptoCapabilities;
        [FieldOffset(20)]
        public uint SizeOfCryptoCapability;
        [FieldOffset(24)]
        public uint IceType;
        [FieldOffset(28)]
        public _STORAGE_SECURITY_COMPLIANCE_BITMASK SecurityComplianceBitmask;
        [FieldOffset(29)]
        public _STORAGE_CRYPTO_KEY_TYPE KeyTypeBitmask;
    }
}