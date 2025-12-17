#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 736)]
    public partial struct _EX_WORK_QUEUE
    {
        [FieldOffset(0)]
        public _KPRIQUEUE WorkPriQueue;
        [FieldOffset(688)]
        public IntPtr Partition;
        [FieldOffset(696)]
        public IntPtr Node;
        [FieldOffset(704)]
        public uint WorkItemsProcessed;
        [FieldOffset(708)]
        public uint WorkItemsProcessedLastPass;
        [FieldOffset(712)]
        public int ThreadCount;
        [FieldOffset(716)]
        public int MinThreads;
        [FieldOffset(716)]
        public uint TryFailed;
        [FieldOffset(720)]
        public int MaxThreads;
        [FieldOffset(724)]
        public uint QueueIndex;
        [FieldOffset(728)]
        public IntPtr AllThreadsExitedEvent;
    }
}