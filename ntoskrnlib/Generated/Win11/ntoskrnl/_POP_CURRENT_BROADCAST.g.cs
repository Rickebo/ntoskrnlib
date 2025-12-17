#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _POP_CURRENT_BROADCAST
    {
        [FieldOffset(0)]
        public byte InProgress;
        [FieldOffset(4)]
        public _SYSTEM_POWER_STATE_CONTEXT SystemContext;
        [FieldOffset(8)]
        public uint PowerAction;
        [FieldOffset(16)]
        public IntPtr DeviceState;
    }
}