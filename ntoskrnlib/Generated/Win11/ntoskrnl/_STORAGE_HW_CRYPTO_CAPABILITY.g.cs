#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _STORAGE_HW_CRYPTO_CAPABILITY
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint Size;
        [FieldOffset(8)]
        public uint CryptoCapabilityIndex;
        [FieldOffset(12)]
        public uint AlgorithmId;
        [FieldOffset(16)]
        public uint KeySize;
        [FieldOffset(20)]
        public uint DataUnitSizeBitmask;
        [FieldOffset(24)]
        public ushort MaxIVBitSize;
        [FieldOffset(26)]
        public ushort Reserved;
        [FieldOffset(28)]
        public _STORAGE_SECURITY_COMPLIANCE_BITMASK SecurityComplianceBitmask;
    }
}