#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _RELATIVE_SYMLINK_INFO
    {
        [FieldOffset(0)]
        public ushort ExposedNamespaceLength;
        [FieldOffset(2)]
        public ushort Flags;
        [FieldOffset(4)]
        public ushort DeviceNameLength;
        [FieldOffset(6)]
        public ushort Reserved;
        [FieldOffset(8)]
        public IntPtr InteriorMountPoint;
        [FieldOffset(16)]
        public _UNICODE_STRING OpenedName;
    }
}