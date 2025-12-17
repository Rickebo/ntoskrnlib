#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _ALPC_DISPATCH_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr PortObject;
        [FieldOffset(8)]
        public IntPtr Message;
        [FieldOffset(16)]
        public IntPtr CommunicationInfo;
        [FieldOffset(24)]
        public IntPtr TargetThread;
        [FieldOffset(32)]
        public IntPtr TargetPort;
        [FieldOffset(40)]
        public _KALPC_DIRECT_EVENT DirectEvent;
        [FieldOffset(48)]
        public uint Flags;
        [FieldOffset(52)]
        public ushort TotalLength;
        [FieldOffset(54)]
        public ushort Type;
        [FieldOffset(56)]
        public ushort DataInfoOffset;
        [FieldOffset(58)]
        public byte SignalCompletion;
        [FieldOffset(59)]
        public byte PostedToCompletionList;
    }
}