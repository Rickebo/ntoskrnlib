#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _IO_REMOVE_LOCK_COMMON_BLOCK
    {
        [FieldOffset(0)]
        public byte Removed;
        [FieldOffset(1)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Reserved;
        [FieldOffset(4)]
        public int IoCount;
        [FieldOffset(8)]
        public _KEVENT RemoveEvent;
    }
}