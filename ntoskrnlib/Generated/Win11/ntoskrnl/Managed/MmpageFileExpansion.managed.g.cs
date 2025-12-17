using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPAGE_FILE_EXPANSION")]
    public sealed class MmpageFileExpansion : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Segment { get => ReadHere<IntPtr>(nameof(Segment)); set => WriteHere(nameof(Segment), value); }

        [Offset(8UL)]
        public ListEntry DereferenceList { get => ReadStructure<ListEntry>(nameof(DereferenceList)); set => WriteStructure(nameof(DereferenceList), value); }

        [Offset(24UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(32UL)]
        public ulong RequestedExpansionSize { get => ReadHere<ulong>(nameof(RequestedExpansionSize)); set => WriteHere(nameof(RequestedExpansionSize), value); }

        [Offset(40UL)]
        public ulong ActualExpansion { get => ReadHere<ulong>(nameof(ActualExpansion)); set => WriteHere(nameof(ActualExpansion), value); }

        [Offset(48UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(72UL)]
        public int InProgress { get => ReadHere<int>(nameof(InProgress)); set => WriteHere(nameof(InProgress), value); }

        [Offset(76UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(80UL)]
        public IntPtr ActiveEntry { get => ReadHere<IntPtr>(nameof(ActiveEntry)); set => WriteHere(nameof(ActiveEntry), value); }

        public MmpageFileExpansion(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpageFileExpansion>();
        }
    }
}