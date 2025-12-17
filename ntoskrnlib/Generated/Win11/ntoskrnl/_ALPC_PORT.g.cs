#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 472)]
    public partial struct _ALPC_PORT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY PortListEntry;
        [FieldOffset(16)]
        public IntPtr CommunicationInfo;
        [FieldOffset(24)]
        public IntPtr OwnerProcess;
        [FieldOffset(32)]
        public IntPtr CompletionPort;
        [FieldOffset(40)]
        public IntPtr CompletionKey;
        [FieldOffset(48)]
        public IntPtr CompletionPacketLookaside;
        [FieldOffset(56)]
        public IntPtr PortContext;
        [FieldOffset(64)]
        public _SECURITY_CLIENT_CONTEXT StaticSecurity;
        [FieldOffset(136)]
        public _EX_PUSH_LOCK IncomingQueueLock;
        [FieldOffset(144)]
        public _LIST_ENTRY MainQueue;
        [FieldOffset(160)]
        public _LIST_ENTRY LargeMessageQueue;
        [FieldOffset(176)]
        public _EX_PUSH_LOCK PendingQueueLock;
        [FieldOffset(184)]
        public _LIST_ENTRY PendingQueue;
        [FieldOffset(200)]
        public _EX_PUSH_LOCK DirectQueueLock;
        [FieldOffset(208)]
        public _LIST_ENTRY DirectQueue;
        [FieldOffset(224)]
        public _EX_PUSH_LOCK WaitQueueLock;
        [FieldOffset(232)]
        public _LIST_ENTRY WaitQueue;
        [FieldOffset(248)]
        public IntPtr Semaphore;
        [FieldOffset(248)]
        public IntPtr DummyEvent;
        [FieldOffset(256)]
        public _ALPC_PORT_ATTRIBUTES PortAttributes;
        [FieldOffset(328)]
        public _EX_PUSH_LOCK ResourceListLock;
        [FieldOffset(336)]
        public _LIST_ENTRY ResourceListHead;
        [FieldOffset(352)]
        public _EX_PUSH_LOCK PortObjectLock;
        [FieldOffset(360)]
        public IntPtr CompletionList;
        [FieldOffset(368)]
        public IntPtr CallbackObject;
        [FieldOffset(376)]
        public IntPtr CallbackContext;
        [FieldOffset(384)]
        public _LIST_ENTRY CanceledQueue;
        [FieldOffset(400)]
        public int SequenceNo;
        [FieldOffset(404)]
        public int ReferenceNo;
        [FieldOffset(408)]
        public IntPtr ReferenceNoWait;
        [FieldOffset(416)]
        public _unnamed_tag_ u1;
        [FieldOffset(424)]
        public IntPtr TargetQueuePort;
        [FieldOffset(432)]
        public IntPtr TargetSequencePort;
        [FieldOffset(440)]
        public IntPtr CachedMessage;
        [FieldOffset(448)]
        public uint MainQueueLength;
        [FieldOffset(452)]
        public uint LargeMessageQueueLength;
        [FieldOffset(456)]
        public uint PendingQueueLength;
        [FieldOffset(460)]
        public uint DirectQueueLength;
        [FieldOffset(464)]
        public uint CanceledQueueLength;
        [FieldOffset(468)]
        public uint WaitQueueLength;
    }
}