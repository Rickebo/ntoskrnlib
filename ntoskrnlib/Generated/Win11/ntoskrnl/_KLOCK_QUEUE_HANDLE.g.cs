#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _KLOCK_QUEUE_HANDLE
    {
        [FieldOffset(0)]
        public _KSPIN_LOCK_QUEUE LockQueue;
        [FieldOffset(16)]
        public byte OldIrql;
    }
}