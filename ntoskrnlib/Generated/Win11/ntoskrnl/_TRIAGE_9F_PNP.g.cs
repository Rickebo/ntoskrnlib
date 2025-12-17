#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _TRIAGE_9F_PNP
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public ushort Revision;
        [FieldOffset(8)]
        public IntPtr CompletionQueue;
        [FieldOffset(16)]
        public IntPtr DelayedWorkQueue;
        [FieldOffset(24)]
        public IntPtr DelayedIoWorkQueue;
        [FieldOffset(32)]
        public IntPtr DeviceNode;
    }
}