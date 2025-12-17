using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_RELATION")]
    public sealed class PopFxRelation : DynamicStructure
    {
        [Offset(0UL)]
        public uint RelationType { get => ReadHere<uint>(nameof(RelationType)); set => WriteHere(nameof(RelationType), value); }

        [Offset(8UL)]
        public ulong RelationLock { get => ReadHere<ulong>(nameof(RelationLock)); set => WriteHere(nameof(RelationLock), value); }

        [Offset(16UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(24UL)]
        public IntPtr ParentComponent { get => ReadHere<IntPtr>(nameof(ParentComponent)); set => WriteHere(nameof(ParentComponent), value); }

        [Offset(32UL)]
        public ListEntry ParentLink { get => ReadStructure<ListEntry>(nameof(ParentLink)); set => WriteStructure(nameof(ParentLink), value); }

        [Offset(48UL)]
        public IntPtr ChildRelationLock { get => ReadHere<IntPtr>(nameof(ChildRelationLock)); set => WriteHere(nameof(ChildRelationLock), value); }

        [Offset(56UL)]
        public ListEntry ChildLink { get => ReadStructure<ListEntry>(nameof(ChildLink)); set => WriteStructure(nameof(ChildLink), value); }

        public PopFxRelation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxRelation>();
        }
    }
}