#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _ETW_BUFFER_QUEUE
    {
        [FieldOffset(0)]
        public IntPtr QueueTail;
        [FieldOffset(8)]
        public _SINGLE_LIST_ENTRY QueueEntry;
    }
}