#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PROC_IDLE_SNAP
    {
        [FieldOffset(0)]
        public ulong Time;
        [FieldOffset(8)]
        public ulong Idle;
    }
}