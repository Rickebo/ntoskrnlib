#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _TPP_TIMER_SUBQUEUE
    {
        [FieldOffset(0)]
        public long Expiration;
        [FieldOffset(8)]
        public _TPP_PH WindowStart;
        [FieldOffset(16)]
        public _TPP_PH WindowEnd;
        [FieldOffset(24)]
        public IntPtr Timer;
        [FieldOffset(32)]
        public IntPtr TimerPkt;
        [FieldOffset(40)]
        public _TP_DIRECT Direct;
        [FieldOffset(112)]
        public uint ExpirationWindow;
    }
}