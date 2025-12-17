#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _CMSI_PROCESS_TUPLE
    {
        [FieldOffset(0)]
        public IntPtr ProcessHandle;
        [FieldOffset(8)]
        public IntPtr ProcessReference;
        [FieldOffset(16)]
        public _CMSI_RW_LOCK WorkingSetLock;
        [FieldOffset(24)]
        public ulong LockedPageCharges;
        [FieldOffset(32)]
        public ulong WorkingSetMinimum;
        [FieldOffset(40)]
        public ulong WorkingSetMaximum;
    }
}