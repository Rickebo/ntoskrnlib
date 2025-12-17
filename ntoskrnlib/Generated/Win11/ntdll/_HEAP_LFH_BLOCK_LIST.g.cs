#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_LFH_BLOCK_LIST
    {
        [FieldOffset(0)]
        public ushort Next;
        [FieldOffset(2)]
        public ushort Count;
        [FieldOffset(0)]
        public _HEAP_LFH_BLOCK_SLIST SList;
        [FieldOffset(0)]
        public uint ListFields;
    }
}