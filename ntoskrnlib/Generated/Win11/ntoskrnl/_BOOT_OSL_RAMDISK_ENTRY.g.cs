#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _BOOT_OSL_RAMDISK_ENTRY
    {
        [FieldOffset(0)]
        public uint BlockSize;
        [FieldOffset(8)]
        public ulong BaseAddress;
        [FieldOffset(16)]
        public ulong Size;
    }
}