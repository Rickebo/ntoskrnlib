#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial struct _NONOPAQUE_OPLOCK
    {
        [FieldOffset(0)]
        public IntPtr IrpExclusiveOplock;
        [FieldOffset(8)]
        public IntPtr FileObject;
        [FieldOffset(16)]
        public IntPtr ExclusiveOplockOwner;
        [FieldOffset(24)]
        public IntPtr ExclusiveOplockOwnerThread;
        [FieldOffset(32)]
        public byte WaiterPriority;
        [FieldOffset(40)]
        public _LIST_ENTRY IrpOplocksR;
        [FieldOffset(56)]
        public _LIST_ENTRY IrpOplocksRH;
        [FieldOffset(72)]
        public _LIST_ENTRY RHBreakQueue;
        [FieldOffset(88)]
        public _LIST_ENTRY WaitingIrps;
        [FieldOffset(104)]
        public _LIST_ENTRY DelayAckFileObjectQueue;
        [FieldOffset(120)]
        public _LIST_ENTRY AtomicQueue;
        [FieldOffset(136)]
        public IntPtr DeleterParentKey;
        [FieldOffset(144)]
        public uint OplockState;
        [FieldOffset(152)]
        public IntPtr FastMutex;
        [FieldOffset(160)]
        public _OPLOCK_TELEMETRY TelemetryData;
        [FieldOffset(176)]
        public IntPtr AckTimeout;
    }
}