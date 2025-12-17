#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public partial struct _POP_FX_WORK_POOL
    {
        [FieldOffset(0)]
        public IntPtr Plugin;
        [FieldOffset(8)]
        public ulong EmergencyWorkQueueLock;
        [FieldOffset(16)]
        public _LIST_ENTRY EmergencyWorkQueue;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _KSEMAPHORE[] WorkPoolQueues;
        [FieldOffset(96)]
        public int WorkItemStatus;
        [FieldOffset(104)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _POP_FX_WORK_POOL_ITEM[] WorkItems;
        [FieldOffset(264)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public IntPtr[] PoolWorkerThreads;
    }
}