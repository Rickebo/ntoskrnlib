#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _RTL_LOOKASIDE
    {
        [FieldOffset(0)]
        public _SLIST_HEADER ListHead;
        [FieldOffset(16)]
        public ushort Depth;
        [FieldOffset(18)]
        public ushort MaximumDepth;
        [FieldOffset(20)]
        public uint TotalAllocates;
        [FieldOffset(24)]
        public uint AllocateMisses;
        [FieldOffset(28)]
        public uint TotalFrees;
        [FieldOffset(32)]
        public uint FreeMisses;
        [FieldOffset(36)]
        public uint LastTotalAllocates;
        [FieldOffset(40)]
        public uint LastAllocateMisses;
        [FieldOffset(44)]
        public uint LastTotalFrees;
    }
}