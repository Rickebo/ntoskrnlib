#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint Size;
        [FieldOffset(8)]
        public uint CryptoIndex;
        [FieldOffset(12)]
        public uint AlgorithmId;
        [FieldOffset(16)]
        public uint DataUnitSize;
        [FieldOffset(20)]
        public uint KeySize;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] KeyHash;
        [FieldOffset(56)]
        public IntPtr KeyVirtualAddress;
        [FieldOffset(64)]
        public _LARGE_INTEGER KeyPhysicalAddress;
        [FieldOffset(72)]
        public _GUID KeyNamespaceId;
        [FieldOffset(88)]
        public int KeyType;
        [FieldOffset(96)]
        public IntPtr AdjustCryptoParametersCallback;
        [FieldOffset(104)]
        public IntPtr AdjustCryptoParametersCallbackContext;
    }
}