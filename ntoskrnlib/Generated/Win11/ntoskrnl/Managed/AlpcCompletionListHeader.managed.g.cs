using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_LIST_HEADER")]
    public sealed class AlpcCompletionListHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ulong StartMagic { get => ReadHere<ulong>(nameof(StartMagic)); set => WriteHere(nameof(StartMagic), value); }

        [Offset(8UL)]
        public uint TotalSize { get => ReadHere<uint>(nameof(TotalSize)); set => WriteHere(nameof(TotalSize), value); }

        [Offset(12UL)]
        public uint ListOffset { get => ReadHere<uint>(nameof(ListOffset)); set => WriteHere(nameof(ListOffset), value); }

        [Offset(16UL)]
        public uint ListSize { get => ReadHere<uint>(nameof(ListSize)); set => WriteHere(nameof(ListSize), value); }

        [Offset(20UL)]
        public uint BitmapOffset { get => ReadHere<uint>(nameof(BitmapOffset)); set => WriteHere(nameof(BitmapOffset), value); }

        [Offset(24UL)]
        public uint BitmapSize { get => ReadHere<uint>(nameof(BitmapSize)); set => WriteHere(nameof(BitmapSize), value); }

        [Offset(28UL)]
        public uint DataOffset { get => ReadHere<uint>(nameof(DataOffset)); set => WriteHere(nameof(DataOffset), value); }

        [Offset(32UL)]
        public uint DataSize { get => ReadHere<uint>(nameof(DataSize)); set => WriteHere(nameof(DataSize), value); }

        [Offset(36UL)]
        public uint AttributeFlags { get => ReadHere<uint>(nameof(AttributeFlags)); set => WriteHere(nameof(AttributeFlags), value); }

        [Offset(40UL)]
        public uint AttributeSize { get => ReadHere<uint>(nameof(AttributeSize)); set => WriteHere(nameof(AttributeSize), value); }

        [Offset(64UL)]
        public AlpcCompletionListState State { get => ReadStructure<AlpcCompletionListState>(nameof(State)); set => WriteStructure(nameof(State), value); }

        [Offset(72UL)]
        public uint LastMessageId { get => ReadHere<uint>(nameof(LastMessageId)); set => WriteHere(nameof(LastMessageId), value); }

        [Offset(76UL)]
        public uint LastCallbackId { get => ReadHere<uint>(nameof(LastCallbackId)); set => WriteHere(nameof(LastCallbackId), value); }

        [Offset(128UL)]
        public uint PostCount { get => ReadHere<uint>(nameof(PostCount)); set => WriteHere(nameof(PostCount), value); }

        [Offset(192UL)]
        public uint ReturnCount { get => ReadHere<uint>(nameof(ReturnCount)); set => WriteHere(nameof(ReturnCount), value); }

        [Offset(256UL)]
        public uint LogSequenceNumber { get => ReadHere<uint>(nameof(LogSequenceNumber)); set => WriteHere(nameof(LogSequenceNumber), value); }

        [Offset(320UL)]
        public RtlSrwlock UserLock { get => ReadStructure<RtlSrwlock>(nameof(UserLock)); set => WriteStructure(nameof(UserLock), value); }

        [Offset(328UL)]
        public ulong EndMagic { get => ReadHere<ulong>(nameof(EndMagic)); set => WriteHere(nameof(EndMagic), value); }

        public AlpcCompletionListHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcCompletionListHeader>();
        }
    }
}