#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MI_PAGE_CHAIN_HEAD
    {
        [FieldOffset(0)]
        public IntPtr Head;
        [FieldOffset(8)]
        public IntPtr Tail;
        [FieldOffset(16)]
        public ulong NumberOfEntries;
    }
}