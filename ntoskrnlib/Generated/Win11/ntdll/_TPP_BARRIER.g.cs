#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _TPP_BARRIER
    {
        [FieldOffset(0)]
        public _TPP_FLAGS_COUNT Ptr;
        [FieldOffset(8)]
        public _RTL_SRWLOCK WaitLock;
        [FieldOffset(16)]
        public _TPP_ITE WaitList;
    }
}