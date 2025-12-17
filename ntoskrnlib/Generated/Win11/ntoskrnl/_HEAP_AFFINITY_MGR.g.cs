#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_AFFINITY_MGR
    {
        [FieldOffset(0)]
        public sbyte MapInProgress;
        [FieldOffset(1)]
        public sbyte ContentionCount;
        [FieldOffset(2)]
        public byte ContentionCountLimit;
        [FieldOffset(3)]
        public byte ConservativeAffinity;
        [FieldOffset(8)]
        public ulong LastContentionTime;
    }
}