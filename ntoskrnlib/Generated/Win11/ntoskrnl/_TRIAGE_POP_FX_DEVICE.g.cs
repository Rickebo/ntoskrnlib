#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _TRIAGE_POP_FX_DEVICE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public IntPtr Irp;
        [FieldOffset(24)]
        public IntPtr IrpData;
        [FieldOffset(32)]
        public int Status;
        [FieldOffset(36)]
        public int PowerReqCall;
        [FieldOffset(40)]
        public int PowerNotReqCall;
        [FieldOffset(48)]
        public IntPtr DeviceNode;
    }
}