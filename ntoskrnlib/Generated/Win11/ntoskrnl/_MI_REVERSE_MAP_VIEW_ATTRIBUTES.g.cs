#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_REVERSE_MAP_VIEW_ATTRIBUTES
    {
        [FieldOffset(0)]
        public ulong FullSectionOffset;
        [FieldOffset(0)]
        public ulong NumberOfPtes;
        [FieldOffset(0)]
        public ulong PartitionId;
        [FieldOffset(0)]
        public ulong SectionOffset;
        [FieldOffset(0)]
        public ulong ViewState;
        [FieldOffset(0)]
        public ulong EntireField;
    }
}