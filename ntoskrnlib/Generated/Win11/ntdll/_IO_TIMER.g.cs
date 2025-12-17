#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _IO_TIMER
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public short TimerFlag;
        [FieldOffset(8)]
        public _LIST_ENTRY TimerList;
        [FieldOffset(24)]
        public IntPtr TimerRoutine;
        [FieldOffset(32)]
        public IntPtr Context;
        [FieldOffset(40)]
        public IntPtr DeviceObject;
    }
}