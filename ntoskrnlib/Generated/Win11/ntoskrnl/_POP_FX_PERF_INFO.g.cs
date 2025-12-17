#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _POP_FX_PERF_INFO
    {
        [FieldOffset(0)]
        public IntPtr Component;
        [FieldOffset(8)]
        public _KEVENT CompletedEvent;
        [FieldOffset(32)]
        public IntPtr ComponentPerfState;
        [FieldOffset(40)]
        public _POP_FX_PERF_FLAGS Flags;
        [FieldOffset(48)]
        public IntPtr LastChange;
        [FieldOffset(56)]
        public uint LastChangeCount;
        [FieldOffset(64)]
        public ulong LastChangeStamp;
        [FieldOffset(72)]
        public byte LastChangeNominal;
        [FieldOffset(73)]
        public byte PepRegistered;
        [FieldOffset(74)]
        public byte QueryOnIdleStates;
        [FieldOffset(80)]
        public IntPtr RequestDriverContext;
        [FieldOffset(88)]
        public _POP_FX_WORK_ORDER WorkOrder;
        [FieldOffset(144)]
        public uint SetsCount;
        [FieldOffset(152)]
        public IntPtr Sets;
    }
}