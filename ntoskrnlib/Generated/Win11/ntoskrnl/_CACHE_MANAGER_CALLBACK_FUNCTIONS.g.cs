#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _CACHE_MANAGER_CALLBACK_FUNCTIONS
    {
        [FieldOffset(0)]
        public IntPtr AcquireForLazyWriteEx;
        [FieldOffset(8)]
        public IntPtr ReleaseFromLazyWrite;
        [FieldOffset(16)]
        public IntPtr AcquireForReadAhead;
        [FieldOffset(24)]
        public IntPtr ReleaseFromReadAhead;
    }
}