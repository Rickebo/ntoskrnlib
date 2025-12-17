#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _MI_SYSTEM_TRIM_STATE
    {
        [FieldOffset(0)]
        public int ExpansionLock;
        [FieldOffset(4)]
        public int TrimInProgressCount;
        [FieldOffset(8)]
        public _KEVENT PeriodicWorkingSetEvent;
        [FieldOffset(32)]
        public _MI_VERIFIER_TRIM_STATE Verifier;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] TrimAllPageFaultCount;
        [FieldOffset(80)]
        public IntPtr EmptyAllThread;
        [FieldOffset(88)]
        public uint FaultedInSystemPage;
    }
}