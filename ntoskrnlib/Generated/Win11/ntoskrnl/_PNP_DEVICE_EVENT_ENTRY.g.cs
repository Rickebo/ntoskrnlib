#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public partial struct _PNP_DEVICE_EVENT_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public uint Argument;
        [FieldOffset(20)]
        public int ArgumentStatus;
        [FieldOffset(24)]
        public IntPtr CallerEvent;
        [FieldOffset(32)]
        public IntPtr Callback;
        [FieldOffset(40)]
        public IntPtr Context;
        [FieldOffset(48)]
        public IntPtr VetoType;
        [FieldOffset(56)]
        public IntPtr VetoName;
        [FieldOffset(64)]
        public uint RefCount;
        [FieldOffset(68)]
        public uint Lock;
        [FieldOffset(72)]
        public byte Cancel;
        [FieldOffset(80)]
        public IntPtr Parent;
        [FieldOffset(88)]
        public _GUID ActivityId;
        [FieldOffset(104)]
        public IntPtr Watchdog;
        [FieldOffset(112)]
        public IntPtr PdcActivatorHandle;
        [FieldOffset(120)]
        public _PLUGPLAY_EVENT_BLOCK Data;
    }
}