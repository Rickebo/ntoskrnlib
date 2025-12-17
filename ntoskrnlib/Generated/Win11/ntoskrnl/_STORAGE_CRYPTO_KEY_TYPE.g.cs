#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _STORAGE_CRYPTO_KEY_TYPE
    {
        [FieldOffset(0)]
        public byte DirectKey;
        [FieldOffset(0)]
        public byte PlatformWrappedKey;
        [FieldOffset(0)]
        public byte PlutonWrappedKey;
        [FieldOffset(0)]
        public byte Reserved;
        [FieldOffset(0)]
        public byte AsUchar;
    }
}