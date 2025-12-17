#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 360)]
    public partial struct _TP_TIMER
    {
        [FieldOffset(0)]
        public _TP_WORK Work;
        [FieldOffset(240)]
        public _RTL_SRWLOCK Lock;
        [FieldOffset(248)]
        public _TPP_PH_LINKS WindowEndLinks;
        [FieldOffset(248)]
        public _LIST_ENTRY ExpirationLinks;
        [FieldOffset(288)]
        public _TPP_PH_LINKS WindowStartLinks;
        [FieldOffset(328)]
        public long DueTime;
        [FieldOffset(336)]
        public _TPP_ITE CancelIte;
        [FieldOffset(344)]
        public uint Window;
        [FieldOffset(348)]
        public uint Period;
        [FieldOffset(352)]
        public byte Inserted;
        [FieldOffset(353)]
        public byte WaitTimer;
        [FieldOffset(354)]
        public byte TimerStatus;
        [FieldOffset(354)]
        public byte InQueue;
        [FieldOffset(354)]
        public byte Absolute;
        [FieldOffset(354)]
        public byte Cancelled;
        [FieldOffset(355)]
        public byte BlockInsert;
    }
}