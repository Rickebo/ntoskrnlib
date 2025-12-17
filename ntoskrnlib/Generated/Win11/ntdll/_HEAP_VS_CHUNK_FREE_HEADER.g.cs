#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _HEAP_VS_CHUNK_FREE_HEADER
    {
        [FieldOffset(0)]
        public _HEAP_VS_CHUNK_HEADER Header;
        [FieldOffset(0)]
        public ulong OverlapsHeader;
        [FieldOffset(8)]
        public _RTL_BALANCED_NODE Node;
    }
}