#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _POP_FX_DRIPS_WATCHDOG_CONTEXT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public uint ComponentIndex;
        [FieldOffset(24)]
        public IntPtr ChildDevices;
        [FieldOffset(32)]
        public uint ChildDeviceCount;
    }
}