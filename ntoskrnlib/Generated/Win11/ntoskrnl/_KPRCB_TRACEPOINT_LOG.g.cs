#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8200)]
    public partial struct _KPRCB_TRACEPOINT_LOG
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public _KPRCB_TRACEPOINT_LOG_ENTRY[] Entries;
        [FieldOffset(8192)]
        public uint LogIndex;
    }
}