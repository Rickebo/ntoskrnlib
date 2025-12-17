#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _KCPU_PARTITION
    {
        [FieldOffset(0)]
        public IntPtr Affinity;
        [FieldOffset(8)]
        public ulong Lock;
        [FieldOffset(16)]
        public _LIST_ENTRY ProcessList;
        [FieldOffset(32)]
        public IntPtr CpuPartitionObject;
        [FieldOffset(40)]
        public _KI_AVAILABLE_CPUS_WORK_ITEM AvailableCpusNotificationWorkItem;
        [FieldOffset(104)]
        public uint Flags;
    }
}