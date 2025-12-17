using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CONTROL_AREA")]
    public sealed class ControlArea : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Segment { get => ReadHere<IntPtr>(nameof(Segment)); set => WriteHere(nameof(Segment), value); }

        [Offset(8UL)]
        public ListEntry ListHead { get => ReadStructure<ListEntry>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(8UL)]
        public IntPtr AweContext { get => ReadHere<IntPtr>(nameof(AweContext)); set => WriteHere(nameof(AweContext), value); }

        [Offset(24UL)]
        public ulong NumberOfSectionReferences { get => ReadHere<ulong>(nameof(NumberOfSectionReferences)); set => WriteHere(nameof(NumberOfSectionReferences), value); }

        [Offset(32UL)]
        public ulong NumberOfPfnReferences { get => ReadHere<ulong>(nameof(NumberOfPfnReferences)); set => WriteHere(nameof(NumberOfPfnReferences), value); }

        [Offset(40UL)]
        public ulong NumberOfMappedViews { get => ReadHere<ulong>(nameof(NumberOfMappedViews)); set => WriteHere(nameof(NumberOfMappedViews), value); }

        [Offset(48UL)]
        public ulong NumberOfUserReferences { get => ReadHere<ulong>(nameof(NumberOfUserReferences)); set => WriteHere(nameof(NumberOfUserReferences), value); }

        [Offset(56UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(60UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(64UL)]
        public ExFastRef FilePointer { get => ReadStructure<ExFastRef>(nameof(FilePointer)); set => WriteStructure(nameof(FilePointer), value); }

        [Offset(72UL)]
        public int ControlAreaLock { get => ReadHere<int>(nameof(ControlAreaLock)); set => WriteHere(nameof(ControlAreaLock), value); }

        [Offset(76UL)]
        public uint ModifiedWriteCount { get => ReadHere<uint>(nameof(ModifiedWriteCount)); set => WriteHere(nameof(ModifiedWriteCount), value); }

        [Offset(80UL)]
        public IntPtr WaitList { get => ReadHere<IntPtr>(nameof(WaitList)); set => WriteHere(nameof(WaitList), value); }

        [Offset(88UL)]
        public UnnamedTag u2 { get => ReadStructure<UnnamedTag>(nameof(u2)); set => WriteStructure(nameof(u2), value); }

        [Offset(104UL)]
        public ExPushLock FileObjectLock { get => ReadStructure<ExPushLock>(nameof(FileObjectLock)); set => WriteStructure(nameof(FileObjectLock), value); }

        [Offset(112UL)]
        public ulong LockedPages { get => ReadHere<ulong>(nameof(LockedPages)); set => WriteHere(nameof(LockedPages), value); }

        [Offset(120UL)]
        public UnnamedTag u3 { get => ReadStructure<UnnamedTag>(nameof(u3)); set => WriteStructure(nameof(u3), value); }

        public ControlArea(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ControlArea>();
        }
    }
}