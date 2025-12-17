#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _KWAIT_BLOCK
    {
        [FieldOffset(0)]
        public _LIST_ENTRY WaitListEntry;
        [FieldOffset(16)]
        public byte WaitType;
        [FieldOffset(17)]
        public byte BlockState;
        [FieldOffset(18)]
        public ushort WaitKey;
        [FieldOffset(20)]
        public int SpareLong;
        [FieldOffset(24)]
        public IntPtr Thread;
        [FieldOffset(24)]
        public IntPtr NotificationQueue;
        [FieldOffset(24)]
        public IntPtr Dpc;
        [FieldOffset(32)]
        public IntPtr Object;
        [FieldOffset(40)]
        public IntPtr SparePtr;
    }
}