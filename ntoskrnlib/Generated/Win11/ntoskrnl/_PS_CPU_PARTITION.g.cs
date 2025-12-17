#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _PS_CPU_PARTITION
    {
        [FieldOffset(0)]
        public IntPtr Partition;
        [FieldOffset(8)]
        public IntPtr Parent;
        [FieldOffset(16)]
        public _LIST_ENTRY PartitionListEntry;
    }
}