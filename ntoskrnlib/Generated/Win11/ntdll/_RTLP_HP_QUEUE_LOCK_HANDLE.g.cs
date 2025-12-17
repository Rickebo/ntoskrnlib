#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTLP_HP_QUEUE_LOCK_HANDLE
    {
        [FieldOffset(0)]
        public ulong Reserved1;
        [FieldOffset(8)]
        public ulong LockPtr;
        [FieldOffset(16)]
        public ulong HandleData;
    }
}