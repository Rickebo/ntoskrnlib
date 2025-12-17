#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _ALPC_COMPLETION_PACKET_LOOKASIDE
    {
        [FieldOffset(0)]
        public ulong Lock;
        [FieldOffset(8)]
        public uint Size;
        [FieldOffset(12)]
        public uint ActiveCount;
        [FieldOffset(16)]
        public uint PendingNullCount;
        [FieldOffset(20)]
        public uint PendingCheckCompletionListCount;
        [FieldOffset(24)]
        public uint PendingDelete;
        [FieldOffset(32)]
        public _SINGLE_LIST_ENTRY FreeListHead;
        [FieldOffset(40)]
        public IntPtr CompletionPort;
        [FieldOffset(48)]
        public IntPtr CompletionKey;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY[] Entry;
    }
}