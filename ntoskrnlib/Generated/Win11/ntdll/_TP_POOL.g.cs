#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 472)]
    public partial struct _TP_POOL
    {
        [FieldOffset(0)]
        public _TPP_REFCOUNT Refcount;
        [FieldOffset(8)]
        public _TPP_POOL_QUEUE_STATE QueueState;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public IntPtr[] TaskQueue;
        [FieldOffset(40)]
        public IntPtr NumaNode;
        [FieldOffset(48)]
        public IntPtr ProximityInfo;
        [FieldOffset(56)]
        public IntPtr WorkerFactory;
        [FieldOffset(64)]
        public IntPtr CompletionPort;
        [FieldOffset(72)]
        public _RTL_SRWLOCK Lock;
        [FieldOffset(80)]
        public _LIST_ENTRY PoolObjectList;
        [FieldOffset(96)]
        public _LIST_ENTRY WorkerList;
        [FieldOffset(112)]
        public _TPP_TIMER_QUEUE TimerQueue;
        [FieldOffset(368)]
        public _RTL_SRWLOCK ShutdownLock;
        [FieldOffset(376)]
        public byte ShutdownInitiated;
        [FieldOffset(377)]
        public byte Released;
        [FieldOffset(378)]
        public ushort PoolFlags;
        [FieldOffset(384)]
        public _LIST_ENTRY PoolLinks;
        [FieldOffset(400)]
        public _TPP_CALLER AllocCaller;
        [FieldOffset(408)]
        public _TPP_CALLER ReleaseCaller;
        [FieldOffset(416)]
        public int AvailableWorkerCount;
        [FieldOffset(420)]
        public int LongRunningWorkerCount;
        [FieldOffset(424)]
        public uint LastProcCount;
        [FieldOffset(428)]
        public int NodeStatus;
        [FieldOffset(432)]
        public int BindingCount;
        [FieldOffset(436)]
        public uint CallbackChecksDisabled;
        [FieldOffset(436)]
        public uint TrimTarget;
        [FieldOffset(436)]
        public uint TrimmedThrdCount;
        [FieldOffset(440)]
        public uint SelectedCpuSetCount;
        [FieldOffset(448)]
        public _RTL_CONDITION_VARIABLE TrimComplete;
        [FieldOffset(456)]
        public _LIST_ENTRY TrimmedWorkerList;
    }
}