using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMINPAGE_SUPPORT")]
    public sealed class MminpageSupport : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(0UL)]
        public SlistEntry SListEntry { get => ReadStructure<SlistEntry>(nameof(SListEntry)); set => WriteStructure(nameof(SListEntry), value); }

        [Offset(16UL)]
        public ListEntry ListHead { get => ReadStructure<ListEntry>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(32UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(56UL)]
        public Kevent CollidedEvent { get => ReadStructure<Kevent>(nameof(CollidedEvent)); set => WriteStructure(nameof(CollidedEvent), value); }

        [Offset(80UL)]
        public IoStatusBlock IoStatus { get => ReadStructure<IoStatusBlock>(nameof(IoStatus)); set => WriteStructure(nameof(IoStatus), value); }

        [Offset(96UL)]
        public LargeInteger ReadOffset { get => ReadStructure<LargeInteger>(nameof(ReadOffset)); set => WriteStructure(nameof(ReadOffset), value); }

        [Offset(104UL)]
        public UnnamedTag u2 { get => ReadStructure<UnnamedTag>(nameof(u2)); set => WriteStructure(nameof(u2), value); }

        [Offset(152UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(160UL)]
        public IntPtr LockedProtoPfn { get => ReadHere<IntPtr>(nameof(LockedProtoPfn)); set => WriteHere(nameof(LockedProtoPfn), value); }

        [Offset(168UL)]
        public Mmpte PteContents { get => ReadStructure<Mmpte>(nameof(PteContents)); set => WriteStructure(nameof(PteContents), value); }

        [Offset(176UL)]
        public int WaitCount { get => ReadHere<int>(nameof(WaitCount)); set => WriteHere(nameof(WaitCount), value); }

        [Offset(180UL)]
        public int InjectRetry { get => ReadHere<int>(nameof(InjectRetry)); set => WriteHere(nameof(InjectRetry), value); }

        [Offset(184UL)]
        public uint ByteCount { get => ReadHere<uint>(nameof(ByteCount)); set => WriteHere(nameof(ByteCount), value); }

        [Offset(188UL)]
        public UnnamedTag u3 { get => ReadStructure<UnnamedTag>(nameof(u3)); set => WriteStructure(nameof(u3), value); }

        [Offset(192UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(200UL)]
        public IntPtr FilePointer { get => ReadHere<IntPtr>(nameof(FilePointer)); set => WriteHere(nameof(FilePointer), value); }

        [Offset(200UL)]
        public IntPtr PagingFile { get => ReadHere<IntPtr>(nameof(PagingFile)); set => WriteHere(nameof(PagingFile), value); }

        [Offset(208UL)]
        public IntPtr Subsection { get => ReadHere<IntPtr>(nameof(Subsection)); set => WriteHere(nameof(Subsection), value); }

        [Offset(216UL)]
        public IntPtr AutoBoostLock { get => ReadHere<IntPtr>(nameof(AutoBoostLock)); set => WriteHere(nameof(AutoBoostLock), value); }

        [Offset(224UL)]
        public IntPtr FaultingAddress { get => ReadHere<IntPtr>(nameof(FaultingAddress)); set => WriteHere(nameof(FaultingAddress), value); }

        [Offset(232UL)]
        public IntPtr PointerPte { get => ReadHere<IntPtr>(nameof(PointerPte)); set => WriteHere(nameof(PointerPte), value); }

        [Offset(240UL)]
        public IntPtr BasePte { get => ReadHere<IntPtr>(nameof(BasePte)); set => WriteHere(nameof(BasePte), value); }

        [Offset(248UL)]
        public IntPtr Pfn { get => ReadHere<IntPtr>(nameof(Pfn)); set => WriteHere(nameof(Pfn), value); }

        [Offset(256UL)]
        public IntPtr PrefetchMdl { get => ReadHere<IntPtr>(nameof(PrefetchMdl)); set => WriteHere(nameof(PrefetchMdl), value); }

        [Offset(264UL)]
        public long ProbeCount { get => ReadHere<long>(nameof(ProbeCount)); set => WriteHere(nameof(ProbeCount), value); }

        [Offset(272UL)]
        public Mdl Mdl { get => ReadStructure<Mdl>(nameof(Mdl)); set => WriteStructure(nameof(Mdl), value); }

        [Offset(320UL)]
        [Length(16)]
        public DynamicArray Page { get => ReadStructure<DynamicArray>(nameof(Page)); set => WriteStructure(nameof(Page), value); }

        [Offset(320UL)]
        public MminpageSupportFlowThrough FlowThrough { get => ReadStructure<MminpageSupportFlowThrough>(nameof(FlowThrough)); set => WriteStructure(nameof(FlowThrough), value); }

        public MminpageSupport(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MminpageSupport>();
        }
    }
}