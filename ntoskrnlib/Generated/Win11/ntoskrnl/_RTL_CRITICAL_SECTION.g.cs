#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _RTL_CRITICAL_SECTION
    {
        [FieldOffset(0)]
        public IntPtr DebugInfo;
        [FieldOffset(8)]
        public int LockCount;
        [FieldOffset(12)]
        public int RecursionCount;
        [FieldOffset(16)]
        public IntPtr OwningThread;
        [FieldOffset(24)]
        public IntPtr LockSemaphore;
        [FieldOffset(32)]
        public ulong SpinCount;
    }
}