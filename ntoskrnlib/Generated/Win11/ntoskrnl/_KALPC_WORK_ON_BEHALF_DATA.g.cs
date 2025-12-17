#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KALPC_WORK_ON_BEHALF_DATA
    {
        [FieldOffset(0)]
        public _ALPC_WORK_ON_BEHALF_TICKET Ticket;
    }
}