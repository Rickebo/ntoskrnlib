using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_DEADLOCK_RESOURCE")]
    public sealed class ViDeadlockResource : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint NodeCount { get => ReadHere<uint>(nameof(NodeCount)); set => WriteHere(nameof(NodeCount), value); }

        [Offset(4UL)]
        public uint RecursionCount { get => ReadHere<uint>(nameof(RecursionCount)); set => WriteHere(nameof(RecursionCount), value); }

        [Offset(8UL)]
        public IntPtr ResourceAddress { get => ReadHere<IntPtr>(nameof(ResourceAddress)); set => WriteHere(nameof(ResourceAddress), value); }

        [Offset(16UL)]
        public IntPtr ThreadOwner { get => ReadHere<IntPtr>(nameof(ThreadOwner)); set => WriteHere(nameof(ThreadOwner), value); }

        [Offset(24UL)]
        public ListEntry ResourceList { get => ReadStructure<ListEntry>(nameof(ResourceList)); set => WriteStructure(nameof(ResourceList), value); }

        [Offset(40UL)]
        public ListEntry HashChainList { get => ReadStructure<ListEntry>(nameof(HashChainList)); set => WriteStructure(nameof(HashChainList), value); }

        [Offset(40UL)]
        public ListEntry FreeListEntry { get => ReadStructure<ListEntry>(nameof(FreeListEntry)); set => WriteStructure(nameof(FreeListEntry), value); }

        [Offset(56UL)]
        [Length(8)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        [Offset(120UL)]
        [Length(8)]
        public DynamicArray LastAcquireTrace { get => ReadStructure<DynamicArray>(nameof(LastAcquireTrace)); set => WriteStructure(nameof(LastAcquireTrace), value); }

        [Offset(184UL)]
        [Length(8)]
        public DynamicArray LastReleaseTrace { get => ReadStructure<DynamicArray>(nameof(LastReleaseTrace)); set => WriteStructure(nameof(LastReleaseTrace), value); }

        public ViDeadlockResource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViDeadlockResource>();
        }
    }
}