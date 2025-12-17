#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EVENT_HEADER_EXTENDED_DATA_ITEM
    {
        [FieldOffset(0)]
        public ushort Reserved1;
        [FieldOffset(2)]
        public ushort ExtType;
        [FieldOffset(4)]
        public ushort Linkage;
        [FieldOffset(4)]
        public ushort Reserved2;
        [FieldOffset(6)]
        public ushort DataSize;
        [FieldOffset(8)]
        public ulong DataPtr;
    }
}