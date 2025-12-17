#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _SUPPORTED_RANGES
    {
        [FieldOffset(0)]
        public ushort Version;
        [FieldOffset(2)]
        public byte Sorted;
        [FieldOffset(3)]
        public byte Reserved;
        [FieldOffset(4)]
        public uint NoIO;
        [FieldOffset(8)]
        public _SUPPORTED_RANGE IO;
        [FieldOffset(48)]
        public uint NoMemory;
        [FieldOffset(56)]
        public _SUPPORTED_RANGE Memory;
        [FieldOffset(96)]
        public uint NoPrefetchMemory;
        [FieldOffset(104)]
        public _SUPPORTED_RANGE PrefetchMemory;
        [FieldOffset(144)]
        public uint NoDma;
        [FieldOffset(152)]
        public _SUPPORTED_RANGE Dma;
    }
}