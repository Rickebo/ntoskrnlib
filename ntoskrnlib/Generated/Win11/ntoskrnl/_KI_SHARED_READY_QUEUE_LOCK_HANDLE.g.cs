#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KI_SHARED_READY_QUEUE_LOCK_HANDLE
    {
        [FieldOffset(0)]
        public _KSPIN_LOCK_QUEUE Queue;
    }
}