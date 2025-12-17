#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public partial struct _EPARTITION
    {
        [FieldOffset(0)]
        public IntPtr MmPartition;
        [FieldOffset(8)]
        public IntPtr CcPartition;
        [FieldOffset(16)]
        public IntPtr ExPartition;
        [FieldOffset(24)]
        public IntPtr SmPartition;
        [FieldOffset(32)]
        public IntPtr PfPartition;
        [FieldOffset(40)]
        public long HardReferenceCount;
        [FieldOffset(48)]
        public long OpenHandleCount;
        [FieldOffset(56)]
        public _LIST_ENTRY ActivePartitionLinks;
        [FieldOffset(72)]
        public IntPtr ParentPartition;
        [FieldOffset(80)]
        public _WORK_QUEUE_ITEM TeardownWorkItem;
        [FieldOffset(112)]
        public _EX_PUSH_LOCK TeardownLock;
        [FieldOffset(120)]
        public IntPtr SystemProcess;
        [FieldOffset(128)]
        public IntPtr SystemProcessHandle;
        [FieldOffset(136)]
        public uint PartitionFlags;
        [FieldOffset(136)]
        public uint PairedWithJob;
    }
}