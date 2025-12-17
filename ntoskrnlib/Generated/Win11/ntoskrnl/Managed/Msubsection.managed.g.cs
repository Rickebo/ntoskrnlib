using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MSUBSECTION")]
    public sealed class Msubsection : DynamicStructure
    {
        [Offset(0UL)]
        public Subsection Core { get => ReadStructure<Subsection>(nameof(Core)); set => WriteStructure(nameof(Core), value); }

        [Offset(56UL)]
        public RtlBalancedNode SubsectionNode { get => ReadStructure<RtlBalancedNode>(nameof(SubsectionNode)); set => WriteStructure(nameof(SubsectionNode), value); }

        [Offset(80UL)]
        public ulong NumberOfMappedViews { get => ReadHere<ulong>(nameof(NumberOfMappedViews)); set => WriteHere(nameof(NumberOfMappedViews), value); }

        [Offset(88UL)]
        public ListEntry DereferenceList { get => ReadStructure<ListEntry>(nameof(DereferenceList)); set => WriteStructure(nameof(DereferenceList), value); }

        [Offset(104UL)]
        public uint NumberOfPfnReferences { get => ReadHere<uint>(nameof(NumberOfPfnReferences)); set => WriteHere(nameof(NumberOfPfnReferences), value); }

        [Offset(108UL)]
        public uint LargeViews { get => ReadHere<uint>(nameof(LargeViews)); set => WriteHere(nameof(LargeViews), value); }

        [Offset(112UL)]
        public IntPtr SubsectionExtentList { get => ReadHere<IntPtr>(nameof(SubsectionExtentList)); set => WriteHere(nameof(SubsectionExtentList), value); }

        [Offset(120UL)]
        public MiPrototypePtesNode ProtosNode { get => ReadStructure<MiPrototypePtesNode>(nameof(ProtosNode)); set => WriteStructure(nameof(ProtosNode), value); }

        public Msubsection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Msubsection>();
        }
    }
}