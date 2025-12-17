#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 280)]
    public partial struct _KALPC_MESSAGE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Entry;
        [FieldOffset(16)]
        public IntPtr PortQueue;
        [FieldOffset(24)]
        public IntPtr OwnerPort;
        [FieldOffset(32)]
        public IntPtr WaitingThread;
        [FieldOffset(40)]
        public _unnamed_tag_ u1;
        [FieldOffset(44)]
        public int SequenceNo;
        [FieldOffset(48)]
        public IntPtr QuotaProcess;
        [FieldOffset(48)]
        public IntPtr QuotaBlock;
        [FieldOffset(56)]
        public IntPtr CancelSequencePort;
        [FieldOffset(64)]
        public IntPtr CancelQueuePort;
        [FieldOffset(72)]
        public int CancelSequenceNo;
        [FieldOffset(80)]
        public _LIST_ENTRY CancelListEntry;
        [FieldOffset(96)]
        public IntPtr Reserve;
        [FieldOffset(104)]
        public _KALPC_MESSAGE_ATTRIBUTES MessageAttributes;
        [FieldOffset(176)]
        public IntPtr DataUserVa;
        [FieldOffset(184)]
        public IntPtr CommunicationInfo;
        [FieldOffset(192)]
        public IntPtr ConnectionPort;
        [FieldOffset(200)]
        public IntPtr ServerThread;
        [FieldOffset(208)]
        public IntPtr WakeReference;
        [FieldOffset(216)]
        public IntPtr WakeReference2;
        [FieldOffset(224)]
        public IntPtr ExtensionBuffer;
        [FieldOffset(232)]
        public ulong ExtensionBufferSize;
        [FieldOffset(240)]
        public _PORT_MESSAGE PortMessage;
    }
}