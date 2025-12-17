using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_PAGE_ACCESS_INFO_HEADER")]
    public sealed class MmPageAccessInfoHeader : DynamicStructure
    {
        [Offset(0UL)]
        public SingleListEntry Link { get => ReadStructure<SingleListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(8UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(12UL)]
        public uint EmptySequenceNumber { get => ReadHere<uint>(nameof(EmptySequenceNumber)); set => WriteHere(nameof(EmptySequenceNumber), value); }

        [Offset(12UL)]
        public uint CurrentFileIndex { get => ReadHere<uint>(nameof(CurrentFileIndex)); set => WriteHere(nameof(CurrentFileIndex), value); }

        [Offset(16UL)]
        public ulong CreateTime { get => ReadHere<ulong>(nameof(CreateTime)); set => WriteHere(nameof(CreateTime), value); }

        [Offset(24UL)]
        public ulong EmptyTime { get => ReadHere<ulong>(nameof(EmptyTime)); set => WriteHere(nameof(EmptyTime), value); }

        [Offset(24UL)]
        public IntPtr TempEntry { get => ReadHere<IntPtr>(nameof(TempEntry)); set => WriteHere(nameof(TempEntry), value); }

        [Offset(32UL)]
        public IntPtr PageEntry { get => ReadHere<IntPtr>(nameof(PageEntry)); set => WriteHere(nameof(PageEntry), value); }

        [Offset(40UL)]
        public IntPtr FileEntry { get => ReadHere<IntPtr>(nameof(FileEntry)); set => WriteHere(nameof(FileEntry), value); }

        [Offset(48UL)]
        public IntPtr FirstFileEntry { get => ReadHere<IntPtr>(nameof(FirstFileEntry)); set => WriteHere(nameof(FirstFileEntry), value); }

        [Offset(56UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(32UL)]
        public IntPtr PageFrameEntry { get => ReadHere<IntPtr>(nameof(PageFrameEntry)); set => WriteHere(nameof(PageFrameEntry), value); }

        [Offset(40UL)]
        public IntPtr LastPageFrameEntry { get => ReadHere<IntPtr>(nameof(LastPageFrameEntry)); set => WriteHere(nameof(LastPageFrameEntry), value); }

        public MmPageAccessInfoHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmPageAccessInfoHeader>();
        }
    }
}