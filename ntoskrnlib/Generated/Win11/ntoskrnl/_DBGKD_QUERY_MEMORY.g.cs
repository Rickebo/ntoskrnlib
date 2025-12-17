#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _DBGKD_QUERY_MEMORY
    {
        [FieldOffset(0)]
        public ulong Address;
        [FieldOffset(8)]
        public ulong Reserved;
        [FieldOffset(16)]
        public uint AddressSpace;
        [FieldOffset(20)]
        public uint Flags;
    }
}