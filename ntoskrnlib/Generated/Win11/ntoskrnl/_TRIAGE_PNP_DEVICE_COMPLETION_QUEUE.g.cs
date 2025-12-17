#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _TRIAGE_PNP_DEVICE_COMPLETION_QUEUE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY DispatchedList;
    }
}