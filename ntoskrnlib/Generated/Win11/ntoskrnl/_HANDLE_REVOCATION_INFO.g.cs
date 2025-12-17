#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _HANDLE_REVOCATION_INFO
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr RevocationBlock;
        [FieldOffset(24)]
        public byte AllowHandleRevocation;
        [FieldOffset(25)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Padding1;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding2;
    }
}