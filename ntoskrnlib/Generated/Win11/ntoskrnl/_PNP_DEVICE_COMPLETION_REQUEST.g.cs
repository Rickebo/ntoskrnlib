#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _PNP_DEVICE_COMPLETION_REQUEST
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr DeviceNode;
        [FieldOffset(24)]
        public IntPtr Context;
        [FieldOffset(32)]
        public uint CompletionState;
        [FieldOffset(36)]
        public uint IrpPended;
        [FieldOffset(40)]
        public int Status;
        [FieldOffset(48)]
        public IntPtr Information;
        [FieldOffset(56)]
        public int ReferenceCount;
        [FieldOffset(64)]
        public IntPtr Watchdog;
    }
}