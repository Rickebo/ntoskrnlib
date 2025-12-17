#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _ALPC_COMMUNICATION_INFO
    {
        [FieldOffset(0)]
        public IntPtr ConnectionPort;
        [FieldOffset(8)]
        public IntPtr ServerCommunicationPort;
        [FieldOffset(16)]
        public IntPtr ClientCommunicationPort;
        [FieldOffset(24)]
        public _LIST_ENTRY CommunicationList;
        [FieldOffset(40)]
        public _ALPC_HANDLE_TABLE HandleTable;
        [FieldOffset(72)]
        public IntPtr CloseMessage;
    }
}