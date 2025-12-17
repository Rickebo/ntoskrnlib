#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 472)]
    public partial struct _POP_DEVICE_SYS_STATE
    {
        [FieldOffset(0)]
        public byte IrpMinor;
        [FieldOffset(4)]
        public uint SystemState;
        [FieldOffset(8)]
        public ulong SpinLock;
        [FieldOffset(16)]
        public IntPtr Thread;
        [FieldOffset(24)]
        public IntPtr AbortEvent;
        [FieldOffset(32)]
        public IntPtr ReadySemaphore;
        [FieldOffset(40)]
        public IntPtr FinishedSemaphore;
        [FieldOffset(48)]
        public _PO_DEVICE_NOTIFY_ORDER Order;
        [FieldOffset(432)]
        public _LIST_ENTRY Pending;
        [FieldOffset(448)]
        public int Status;
        [FieldOffset(456)]
        public IntPtr FailedDevice;
        [FieldOffset(464)]
        public byte Waking;
        [FieldOffset(465)]
        public byte Cancelled;
        [FieldOffset(466)]
        public byte IgnoreErrors;
        [FieldOffset(467)]
        public byte IgnoreNotImplemented;
        [FieldOffset(468)]
        public byte TimeRefreshLockAcquired;
    }
}