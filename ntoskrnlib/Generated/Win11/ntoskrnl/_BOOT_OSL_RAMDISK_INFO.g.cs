#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _BOOT_OSL_RAMDISK_INFO
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint Count;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _BOOT_OSL_RAMDISK_ENTRY[] Entries;
    }
}