#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _POP_SHUTDOWN_BUG_CHECK
    {
        [FieldOffset(0)]
        public IntPtr InitiatingThread;
        [FieldOffset(8)]
        public IntPtr InitiatingProcess;
        [FieldOffset(16)]
        public IntPtr ThreadId;
        [FieldOffset(24)]
        public IntPtr ProcessId;
        [FieldOffset(32)]
        public uint Code;
        [FieldOffset(40)]
        public ulong Parameter1;
        [FieldOffset(48)]
        public ulong Parameter2;
        [FieldOffset(56)]
        public ulong Parameter3;
        [FieldOffset(64)]
        public ulong Parameter4;
    }
}