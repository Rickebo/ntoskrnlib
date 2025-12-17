#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _WORK_QUEUE_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY WorkQueueLinks;
        [FieldOffset(16)]
        public _unnamed_tag_ Parameters;
        [FieldOffset(128)]
        public uint Function;
        [FieldOffset(136)]
        public IntPtr Partition;
        [FieldOffset(144)]
        public IntPtr PrivateVolumeCacheMap;
        [FieldOffset(152)]
        public IntPtr NumaNode;
    }
}