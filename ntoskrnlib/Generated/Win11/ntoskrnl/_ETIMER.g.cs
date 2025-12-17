#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public partial struct _ETIMER
    {
        [FieldOffset(0)]
        public _KTIMER KeTimer;
        [FieldOffset(64)]
        public ulong Lock;
        [FieldOffset(72)]
        public _KAPC TimerApc;
        [FieldOffset(160)]
        public _KDPC TimerDpc;
        [FieldOffset(224)]
        public _LIST_ENTRY ActiveTimerListEntry;
        [FieldOffset(240)]
        public uint Period;
        [FieldOffset(244)]
        public sbyte TimerFlags;
        [FieldOffset(244)]
        public byte ApcAssociated;
        [FieldOffset(244)]
        public byte FlushDpcs;
        [FieldOffset(244)]
        public byte Paused;
        [FieldOffset(244)]
        public byte Spare1;
        [FieldOffset(245)]
        public byte DueTimeType;
        [FieldOffset(246)]
        public ushort Spare2;
        [FieldOffset(248)]
        public IntPtr WakeReason;
        [FieldOffset(256)]
        public _LIST_ENTRY WakeTimerListEntry;
        [FieldOffset(272)]
        public IntPtr VirtualizedTimerCookie;
        [FieldOffset(280)]
        public _LIST_ENTRY VirtualizedTimerLinks;
        [FieldOffset(296)]
        public ulong DueTime;
        [FieldOffset(304)]
        public uint CoalescingWindow;
    }
}