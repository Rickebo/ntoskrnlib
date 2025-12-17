using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_DEADLOCK_NODE")]
    public sealed class ViDeadlockNode : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(8UL)]
        public ListEntry ChildrenList { get => ReadStructure<ListEntry>(nameof(ChildrenList)); set => WriteStructure(nameof(ChildrenList), value); }

        [Offset(24UL)]
        public ListEntry SiblingsList { get => ReadStructure<ListEntry>(nameof(SiblingsList)); set => WriteStructure(nameof(SiblingsList), value); }

        [Offset(40UL)]
        public ListEntry ResourceList { get => ReadStructure<ListEntry>(nameof(ResourceList)); set => WriteStructure(nameof(ResourceList), value); }

        [Offset(40UL)]
        public ListEntry FreeListEntry { get => ReadStructure<ListEntry>(nameof(FreeListEntry)); set => WriteStructure(nameof(FreeListEntry), value); }

        [Offset(56UL)]
        public IntPtr Root { get => ReadHere<IntPtr>(nameof(Root)); set => WriteHere(nameof(Root), value); }

        [Offset(64UL)]
        public IntPtr ThreadEntry { get => ReadHere<IntPtr>(nameof(ThreadEntry)); set => WriteHere(nameof(ThreadEntry), value); }

        [Offset(72UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(76UL)]
        public int ChildrenCount { get => ReadHere<int>(nameof(ChildrenCount)); set => WriteHere(nameof(ChildrenCount), value); }

        [Offset(80UL)]
        [Length(8)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        [Offset(144UL)]
        [Length(8)]
        public DynamicArray ParentStackTrace { get => ReadStructure<DynamicArray>(nameof(ParentStackTrace)); set => WriteStructure(nameof(ParentStackTrace), value); }

        public ViDeadlockNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViDeadlockNode>();
        }
    }
}