#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO
    {
        [FieldOffset(0)]
        public _KDPC EventDpc;
        [FieldOffset(64)]
        public IntPtr DeferredRoutine;
        [FieldOffset(72)]
        public uint TickCount;
    }
}