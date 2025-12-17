#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KLOCK_ENTRY_LOCK_STATE
    {
        [FieldOffset(0)]
        public ulong CrossThreadReleasable;
        [FieldOffset(0)]
        public ulong Busy;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong InTree;
        [FieldOffset(0)]
        public IntPtr LockState;
    }
}