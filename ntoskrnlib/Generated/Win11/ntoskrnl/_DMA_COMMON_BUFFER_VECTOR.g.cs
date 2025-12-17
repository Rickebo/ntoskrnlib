#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _DMA_COMMON_BUFFER_VECTOR
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public ulong SizeOfEntries;
        [FieldOffset(24)]
        public uint NumberOfEntries;
        [FieldOffset(32)]
        public IntPtr Domain;
        [FieldOffset(40)]
        public IntPtr Mdl;
        [FieldOffset(48)]
        public IntPtr BaseAddress;
        [FieldOffset(56)]
        public ulong BaseLogicalAddress;
        [FieldOffset(64)]
        public IntPtr Entries;
        [FieldOffset(72)]
        public byte LogicalAddressMapped;
    }
}