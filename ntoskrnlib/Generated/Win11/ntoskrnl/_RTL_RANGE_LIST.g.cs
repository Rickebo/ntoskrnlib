#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _RTL_RANGE_LIST
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListHead;
        [FieldOffset(16)]
        public uint Flags;
        [FieldOffset(20)]
        public uint Count;
        [FieldOffset(24)]
        public uint Stamp;
    }
}