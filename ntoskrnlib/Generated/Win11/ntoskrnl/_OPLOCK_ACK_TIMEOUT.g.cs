#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial struct _OPLOCK_ACK_TIMEOUT
    {
        [FieldOffset(0)]
        public _KTIMER Timer;
        [FieldOffset(64)]
        public _KDPC Dpc;
        [FieldOffset(128)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(160)]
        public IntPtr Oplock;
        [FieldOffset(168)]
        public IntPtr OplockRequestFileObject;
        [FieldOffset(176)]
        public uint OplockOwnerIntegrityLevel;
        [FieldOffset(180)]
        public byte TimerSet;
        [FieldOffset(181)]
        public byte AckDone;
    }
}