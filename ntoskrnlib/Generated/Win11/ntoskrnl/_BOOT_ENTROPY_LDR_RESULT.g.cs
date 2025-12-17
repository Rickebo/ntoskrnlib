#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2152)]
    public partial struct _BOOT_ENTROPY_LDR_RESULT
    {
        [FieldOffset(0)]
        public uint maxEntropySources;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public _BOOT_ENTROPY_SOURCE_LDR_RESULT[] EntropySourceResult;
        [FieldOffset(1048)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] SeedBytesForCng;
        [FieldOffset(1096)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        public byte[] RngBytesForNtoskrnl;
        [FieldOffset(2120)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] KdEntropy;
    }
}