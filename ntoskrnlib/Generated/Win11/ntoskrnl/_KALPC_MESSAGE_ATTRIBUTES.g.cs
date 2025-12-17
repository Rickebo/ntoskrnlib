#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _KALPC_MESSAGE_ATTRIBUTES
    {
        [FieldOffset(0)]
        public IntPtr ClientContext;
        [FieldOffset(8)]
        public IntPtr ServerContext;
        [FieldOffset(16)]
        public IntPtr PortContext;
        [FieldOffset(24)]
        public IntPtr CancelPortContext;
        [FieldOffset(32)]
        public IntPtr SecurityData;
        [FieldOffset(40)]
        public IntPtr View;
        [FieldOffset(48)]
        public IntPtr HandleData;
        [FieldOffset(56)]
        public _KALPC_DIRECT_EVENT DirectEvent;
        [FieldOffset(64)]
        public _KALPC_WORK_ON_BEHALF_DATA WorkOnBehalfData;
    }
}