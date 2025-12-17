#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _WORK_QUEUE_ITEM
    {
        [FieldOffset(0)]
        public _LIST_ENTRY List;
        [FieldOffset(16)]
        public IntPtr WorkerRoutine;
        [FieldOffset(24)]
        public IntPtr Parameter;
    }
}