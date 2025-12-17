#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 280)]
    public partial struct _EX_WORK_QUEUE_MANAGER
    {
        [FieldOffset(0)]
        public IntPtr Partition;
        [FieldOffset(8)]
        public IntPtr Node;
        [FieldOffset(16)]
        public _KEVENT Event;
        [FieldOffset(40)]
        public _KTIMER DeadlockTimer;
        [FieldOffset(104)]
        public _KEVENT ReaperEvent;
        [FieldOffset(128)]
        public _KTIMER2 ReaperTimer;
        [FieldOffset(264)]
        public IntPtr ThreadHandle;
        [FieldOffset(272)]
        public uint ExitThread;
        [FieldOffset(276)]
        public ushort ThreadSeed;
    }
}