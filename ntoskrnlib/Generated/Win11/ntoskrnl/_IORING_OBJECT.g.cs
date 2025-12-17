#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public partial struct _IORING_OBJECT
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public short Size;
        [FieldOffset(8)]
        public _NT_IORING_INFO UserInfo;
        [FieldOffset(56)]
        public IntPtr Section;
        [FieldOffset(64)]
        public IntPtr SubmissionQueue;
        [FieldOffset(72)]
        public IntPtr CompletionQueueMdl;
        [FieldOffset(80)]
        public IntPtr CompletionQueue;
        [FieldOffset(88)]
        public ulong ViewSize;
        [FieldOffset(96)]
        public int InSubmit;
        [FieldOffset(104)]
        public ulong CompletionLock;
        [FieldOffset(112)]
        public ulong SubmitCount;
        [FieldOffset(120)]
        public ulong CompletionCount;
        [FieldOffset(128)]
        public ulong CompletionWaitUntil;
        [FieldOffset(136)]
        public _KEVENT CompletionEvent;
        [FieldOffset(160)]
        public byte SignalCompletionEvent;
        [FieldOffset(168)]
        public IntPtr CompletionUserEvent;
        [FieldOffset(176)]
        public uint RegBuffersCount;
        [FieldOffset(184)]
        public IntPtr RegBuffers;
        [FieldOffset(192)]
        public uint RegFilesCount;
        [FieldOffset(200)]
        public IntPtr RegFiles;
    }
}