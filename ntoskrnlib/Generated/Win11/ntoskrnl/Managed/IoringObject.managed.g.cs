using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IORING_OBJECT")]
    public sealed class IoringObject : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public NtIoringInfo UserInfo { get => ReadStructure<NtIoringInfo>(nameof(UserInfo)); set => WriteStructure(nameof(UserInfo), value); }

        [Offset(56UL)]
        public IntPtr Section { get => ReadHere<IntPtr>(nameof(Section)); set => WriteHere(nameof(Section), value); }

        [Offset(64UL)]
        public IntPtr SubmissionQueue { get => ReadHere<IntPtr>(nameof(SubmissionQueue)); set => WriteHere(nameof(SubmissionQueue), value); }

        [Offset(72UL)]
        public IntPtr CompletionQueueMdl { get => ReadHere<IntPtr>(nameof(CompletionQueueMdl)); set => WriteHere(nameof(CompletionQueueMdl), value); }

        [Offset(80UL)]
        public IntPtr CompletionQueue { get => ReadHere<IntPtr>(nameof(CompletionQueue)); set => WriteHere(nameof(CompletionQueue), value); }

        [Offset(88UL)]
        public ulong ViewSize { get => ReadHere<ulong>(nameof(ViewSize)); set => WriteHere(nameof(ViewSize), value); }

        [Offset(96UL)]
        public int InSubmit { get => ReadHere<int>(nameof(InSubmit)); set => WriteHere(nameof(InSubmit), value); }

        [Offset(104UL)]
        public ulong CompletionLock { get => ReadHere<ulong>(nameof(CompletionLock)); set => WriteHere(nameof(CompletionLock), value); }

        [Offset(112UL)]
        public ulong SubmitCount { get => ReadHere<ulong>(nameof(SubmitCount)); set => WriteHere(nameof(SubmitCount), value); }

        [Offset(120UL)]
        public ulong CompletionCount { get => ReadHere<ulong>(nameof(CompletionCount)); set => WriteHere(nameof(CompletionCount), value); }

        [Offset(128UL)]
        public ulong CompletionWaitUntil { get => ReadHere<ulong>(nameof(CompletionWaitUntil)); set => WriteHere(nameof(CompletionWaitUntil), value); }

        [Offset(136UL)]
        public Kevent CompletionEvent { get => ReadStructure<Kevent>(nameof(CompletionEvent)); set => WriteStructure(nameof(CompletionEvent), value); }

        [Offset(160UL)]
        public byte SignalCompletionEvent { get => ReadHere<byte>(nameof(SignalCompletionEvent)); set => WriteHere(nameof(SignalCompletionEvent), value); }

        [Offset(168UL)]
        public IntPtr CompletionUserEvent { get => ReadHere<IntPtr>(nameof(CompletionUserEvent)); set => WriteHere(nameof(CompletionUserEvent), value); }

        [Offset(176UL)]
        public uint RegBuffersCount { get => ReadHere<uint>(nameof(RegBuffersCount)); set => WriteHere(nameof(RegBuffersCount), value); }

        [Offset(184UL)]
        public IntPtr RegBuffers { get => ReadHere<IntPtr>(nameof(RegBuffers)); set => WriteHere(nameof(RegBuffers), value); }

        [Offset(192UL)]
        public uint RegFilesCount { get => ReadHere<uint>(nameof(RegFilesCount)); set => WriteHere(nameof(RegFilesCount), value); }

        [Offset(200UL)]
        public IntPtr RegFiles { get => ReadHere<IntPtr>(nameof(RegFiles)); set => WriteHere(nameof(RegFiles), value); }

        public IoringObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoringObject>();
        }
    }
}