#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _KALPC_RESERVE
    {
        [FieldOffset(0)]
        public IntPtr OwnerPort;
        [FieldOffset(8)]
        public IntPtr HandleTable;
        [FieldOffset(16)]
        public IntPtr Handle;
        [FieldOffset(24)]
        public IntPtr Message;
        [FieldOffset(32)]
        public ulong Size;
        [FieldOffset(40)]
        public int Active;
    }
}