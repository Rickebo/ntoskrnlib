#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _TPP_QUEUE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Queue;
        [FieldOffset(16)]
        public _RTL_SRWLOCK Lock;
    }
}