#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG
    {
        [FieldOffset(0)]
        public uint Size;
        [FieldOffset(8)]
        public IntPtr TriggerId;
    }
}