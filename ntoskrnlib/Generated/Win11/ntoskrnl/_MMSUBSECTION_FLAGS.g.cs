#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMSUBSECTION_FLAGS
    {
        [FieldOffset(0)]
        public uint SubsectionAccessed;
        [FieldOffset(0)]
        public uint Protection;
        [FieldOffset(0)]
        public uint StartingSector4132;
        [FieldOffset(0)]
        public uint SubsectionStatic;
        [FieldOffset(0)]
        public uint GlobalMemory;
        [FieldOffset(0)]
        public uint Spare;
        [FieldOffset(0)]
        public uint OnDereferenceList;
        [FieldOffset(0)]
        public uint SectorEndOffset;
        [FieldOffset(0)]
        public uint EntireField;
    }
}