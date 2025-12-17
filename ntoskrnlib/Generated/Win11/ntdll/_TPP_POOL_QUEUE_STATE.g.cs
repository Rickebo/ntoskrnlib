#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _TPP_POOL_QUEUE_STATE
    {
        [FieldOffset(0)]
        public long Exchange;
        [FieldOffset(0)]
        public int RunningThreadGoal;
        [FieldOffset(0)]
        public uint PendingReleaseCount;
        [FieldOffset(4)]
        public uint QueueLength;
    }
}