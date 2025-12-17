#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _VI_POOL_ENTRY_INUSE
    {
        [FieldOffset(0)]
        public IntPtr VirtualAddress;
        [FieldOffset(8)]
        public IntPtr CallingAddress;
        [FieldOffset(16)]
        public ulong NumberOfBytes;
        [FieldOffset(24)]
        public ulong Tag;
    }
}