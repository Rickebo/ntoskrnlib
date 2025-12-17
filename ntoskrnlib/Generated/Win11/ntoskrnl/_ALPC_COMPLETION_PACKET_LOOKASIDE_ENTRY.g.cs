#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY
    {
        [FieldOffset(0)]
        public _SINGLE_LIST_ENTRY ListEntry;
        [FieldOffset(8)]
        public IntPtr Packet;
        [FieldOffset(16)]
        public IntPtr Lookaside;
    }
}