#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _HEAP_LFH_COMMIT_UNIT_INFO
    {
        [FieldOffset(0)]
        public byte CommitUnitShift;
        [FieldOffset(1)]
        public byte CommitUnitCount;
        [FieldOffset(0)]
        public ushort UShort;
    }
}