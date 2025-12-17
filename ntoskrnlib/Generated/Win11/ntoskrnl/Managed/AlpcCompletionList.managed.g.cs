using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_LIST")]
    public sealed class AlpcCompletionList : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Entry { get => ReadStructure<ListEntry>(nameof(Entry)); set => WriteStructure(nameof(Entry), value); }

        [Offset(16UL)]
        public IntPtr OwnerProcess { get => ReadHere<IntPtr>(nameof(OwnerProcess)); set => WriteHere(nameof(OwnerProcess), value); }

        [Offset(24UL)]
        public ExPushLock CompletionListLock { get => ReadStructure<ExPushLock>(nameof(CompletionListLock)); set => WriteStructure(nameof(CompletionListLock), value); }

        [Offset(32UL)]
        public IntPtr Mdl { get => ReadHere<IntPtr>(nameof(Mdl)); set => WriteHere(nameof(Mdl), value); }

        [Offset(40UL)]
        public IntPtr UserVa { get => ReadHere<IntPtr>(nameof(UserVa)); set => WriteHere(nameof(UserVa), value); }

        [Offset(48UL)]
        public IntPtr UserLimit { get => ReadHere<IntPtr>(nameof(UserLimit)); set => WriteHere(nameof(UserLimit), value); }

        [Offset(56UL)]
        public IntPtr DataUserVa { get => ReadHere<IntPtr>(nameof(DataUserVa)); set => WriteHere(nameof(DataUserVa), value); }

        [Offset(64UL)]
        public IntPtr SystemVa { get => ReadHere<IntPtr>(nameof(SystemVa)); set => WriteHere(nameof(SystemVa), value); }

        [Offset(72UL)]
        public ulong TotalSize { get => ReadHere<ulong>(nameof(TotalSize)); set => WriteHere(nameof(TotalSize), value); }

        [Offset(80UL)]
        public IntPtr Header { get => ReadHere<IntPtr>(nameof(Header)); set => WriteHere(nameof(Header), value); }

        [Offset(88UL)]
        public IntPtr List { get => ReadHere<IntPtr>(nameof(List)); set => WriteHere(nameof(List), value); }

        [Offset(96UL)]
        public ulong ListSize { get => ReadHere<ulong>(nameof(ListSize)); set => WriteHere(nameof(ListSize), value); }

        [Offset(104UL)]
        public IntPtr Bitmap { get => ReadHere<IntPtr>(nameof(Bitmap)); set => WriteHere(nameof(Bitmap), value); }

        [Offset(112UL)]
        public ulong BitmapSize { get => ReadHere<ulong>(nameof(BitmapSize)); set => WriteHere(nameof(BitmapSize), value); }

        [Offset(120UL)]
        public IntPtr Data { get => ReadHere<IntPtr>(nameof(Data)); set => WriteHere(nameof(Data), value); }

        [Offset(128UL)]
        public ulong DataSize { get => ReadHere<ulong>(nameof(DataSize)); set => WriteHere(nameof(DataSize), value); }

        [Offset(136UL)]
        public uint BitmapLimit { get => ReadHere<uint>(nameof(BitmapLimit)); set => WriteHere(nameof(BitmapLimit), value); }

        [Offset(140UL)]
        public uint BitmapNextHint { get => ReadHere<uint>(nameof(BitmapNextHint)); set => WriteHere(nameof(BitmapNextHint), value); }

        [Offset(144UL)]
        public uint ConcurrencyCount { get => ReadHere<uint>(nameof(ConcurrencyCount)); set => WriteHere(nameof(ConcurrencyCount), value); }

        [Offset(148UL)]
        public uint AttributeFlags { get => ReadHere<uint>(nameof(AttributeFlags)); set => WriteHere(nameof(AttributeFlags), value); }

        [Offset(152UL)]
        public uint AttributeSize { get => ReadHere<uint>(nameof(AttributeSize)); set => WriteHere(nameof(AttributeSize), value); }

        public AlpcCompletionList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcCompletionList>();
        }
    }
}