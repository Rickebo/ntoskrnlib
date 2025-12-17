#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KTIMER_EXPIRATION_TRACE
    {
        [FieldOffset(0)]
        public ulong InterruptTime;
        [FieldOffset(8)]
        public _LARGE_INTEGER PerformanceCounter;
    }
}