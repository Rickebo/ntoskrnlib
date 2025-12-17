#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _DBGK_SILOSTATE
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK ErrorPortLock;
        [FieldOffset(8)]
        public IntPtr ErrorPort;
        [FieldOffset(16)]
        public IntPtr ErrorProcess;
        [FieldOffset(24)]
        public IntPtr ErrorPortRegisteredEvent;
    }
}