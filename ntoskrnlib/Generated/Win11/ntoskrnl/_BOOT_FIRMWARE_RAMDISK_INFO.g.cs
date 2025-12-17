#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _BOOT_FIRMWARE_RAMDISK_INFO
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint BlockSize;
        [FieldOffset(8)]
        public ulong BaseAddress;
        [FieldOffset(16)]
        public ulong Size;
    }
}