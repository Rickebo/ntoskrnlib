#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _NT_IORING_INFO
    {
        [FieldOffset(0)]
        public uint IoRingVersion;
        [FieldOffset(4)]
        public _NT_IORING_CREATE_FLAGS Flags;
        [FieldOffset(12)]
        public uint SubmissionQueueSize;
        [FieldOffset(16)]
        public uint SubmissionQueueRingMask;
        [FieldOffset(20)]
        public uint CompletionQueueSize;
        [FieldOffset(24)]
        public uint CompletionQueueRingMask;
        [FieldOffset(32)]
        public IntPtr SubmissionQueue;
        [FieldOffset(40)]
        public IntPtr CompletionQueue;
    }
}