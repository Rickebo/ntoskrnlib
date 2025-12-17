#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _VACB_ARRAY_HEADER
    {
        [FieldOffset(0)]
        public uint VacbArrayIndex;
        [FieldOffset(4)]
        public uint MappingCount;
        [FieldOffset(8)]
        public uint HighestMappedIndex;
        [FieldOffset(12)]
        public uint Reserved;
    }
}