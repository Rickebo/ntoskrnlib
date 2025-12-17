#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_PSEUDO_TAG_ENTRY
    {
        [FieldOffset(0)]
        public uint Allocs;
        [FieldOffset(4)]
        public uint Frees;
        [FieldOffset(8)]
        public ulong Size;
    }
}