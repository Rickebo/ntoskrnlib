#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _TRIAGE_9F_POWER
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public ushort Revision;
        [FieldOffset(8)]
        public IntPtr IrpList;
        [FieldOffset(16)]
        public IntPtr ThreadList;
        [FieldOffset(24)]
        public IntPtr DelayedWorkQueue;
        [FieldOffset(32)]
        public IntPtr DelayedIoWorkQueue;
    }
}