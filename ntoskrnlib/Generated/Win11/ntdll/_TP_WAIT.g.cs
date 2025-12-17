#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 472)]
    public partial struct _TP_WAIT
    {
        [FieldOffset(0)]
        public _TP_TIMER Timer;
        [FieldOffset(360)]
        public IntPtr Handle;
        [FieldOffset(368)]
        public IntPtr WaitPkt;
        [FieldOffset(376)]
        public IntPtr NextWaitHandle;
        [FieldOffset(384)]
        public _LARGE_INTEGER NextWaitTimeout;
        [FieldOffset(392)]
        public _TP_DIRECT Direct;
        [FieldOffset(464)]
        public _unnamed_tag_ WaitFlags;
    }
}