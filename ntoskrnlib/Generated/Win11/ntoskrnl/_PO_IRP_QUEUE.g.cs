#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PO_IRP_QUEUE
    {
        [FieldOffset(0)]
        public IntPtr CurrentIrp;
        [FieldOffset(8)]
        public IntPtr PendingIrpList;
    }
}