#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _PNP_DEVICE_ACTION_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr DeviceObject;
        [FieldOffset(24)]
        public uint RequestType;
        [FieldOffset(28)]
        public byte ReorderingBarrier;
        [FieldOffset(32)]
        public _PNP_DEVICE_ACTION_REQUEST_ARGUMENT RequestArgument;
        [FieldOffset(48)]
        public IntPtr CompletionEvent;
        [FieldOffset(56)]
        public IntPtr CompletionStatus;
        [FieldOffset(64)]
        public _GUID ActivityId;
        [FieldOffset(80)]
        public int RefCount;
        [FieldOffset(84)]
        public byte Dequeued;
        [FieldOffset(88)]
        public _EX_PUSH_LOCK CancelLock;
        [FieldOffset(96)]
        public byte CancelRequested;
    }
}