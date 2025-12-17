#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MM_PAGE_ACCESS_INFO
    {
        [FieldOffset(0)]
        public _MM_PAGE_ACCESS_INFO_FLAGS Flags;
        [FieldOffset(0)]
        public ulong FileOffset;
        [FieldOffset(0)]
        public IntPtr VirtualAddress;
        [FieldOffset(0)]
        public IntPtr PointerProtoPte;
    }
}