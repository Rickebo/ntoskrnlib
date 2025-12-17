#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HIVE_WRITE_WAIT_QUEUE
    {
        [FieldOffset(0)]
        public IntPtr ActiveThread;
        [FieldOffset(8)]
        public IntPtr WaitList;
    }
}