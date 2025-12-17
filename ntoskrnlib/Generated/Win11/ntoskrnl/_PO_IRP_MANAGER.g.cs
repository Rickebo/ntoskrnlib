#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _PO_IRP_MANAGER
    {
        [FieldOffset(0)]
        public _PO_IRP_QUEUE DeviceIrpQueue;
        [FieldOffset(16)]
        public _PO_IRP_QUEUE SystemIrpQueue;
    }
}