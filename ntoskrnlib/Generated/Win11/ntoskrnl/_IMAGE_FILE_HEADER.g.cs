#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _IMAGE_FILE_HEADER
    {
        [FieldOffset(0)]
        public ushort Machine;
        [FieldOffset(2)]
        public ushort NumberOfSections;
        [FieldOffset(4)]
        public uint TimeDateStamp;
        [FieldOffset(8)]
        public uint PointerToSymbolTable;
        [FieldOffset(12)]
        public uint NumberOfSymbols;
        [FieldOffset(16)]
        public ushort SizeOfOptionalHeader;
        [FieldOffset(18)]
        public ushort Characteristics;
    }
}