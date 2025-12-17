#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ALPC_WORK_ON_BEHALF_TICKET
    {
        [FieldOffset(0)]
        public uint ThreadId;
        [FieldOffset(4)]
        public uint ThreadCreationTimeLow;
    }
}