using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_INFO")]
    public sealed class NtIoringInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint IoRingVersion { get => ReadHere<uint>(nameof(IoRingVersion)); set => WriteHere(nameof(IoRingVersion), value); }

        [Offset(4UL)]
        public NtIoringCreateFlags Flags { get => ReadStructure<NtIoringCreateFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(12UL)]
        public uint SubmissionQueueSize { get => ReadHere<uint>(nameof(SubmissionQueueSize)); set => WriteHere(nameof(SubmissionQueueSize), value); }

        [Offset(16UL)]
        public uint SubmissionQueueRingMask { get => ReadHere<uint>(nameof(SubmissionQueueRingMask)); set => WriteHere(nameof(SubmissionQueueRingMask), value); }

        [Offset(20UL)]
        public uint CompletionQueueSize { get => ReadHere<uint>(nameof(CompletionQueueSize)); set => WriteHere(nameof(CompletionQueueSize), value); }

        [Offset(24UL)]
        public uint CompletionQueueRingMask { get => ReadHere<uint>(nameof(CompletionQueueRingMask)); set => WriteHere(nameof(CompletionQueueRingMask), value); }

        [Offset(32UL)]
        public IntPtr SubmissionQueue { get => ReadHere<IntPtr>(nameof(SubmissionQueue)); set => WriteHere(nameof(SubmissionQueue), value); }

        [Offset(40UL)]
        public IntPtr CompletionQueue { get => ReadHere<IntPtr>(nameof(CompletionQueue)); set => WriteHere(nameof(CompletionQueue), value); }

        public NtIoringInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringInfo>();
        }
    }
}