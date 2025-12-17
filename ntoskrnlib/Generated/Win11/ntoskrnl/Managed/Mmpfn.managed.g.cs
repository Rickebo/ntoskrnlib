using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPFN")]
    public sealed class Mmpfn : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(0UL)]
        public RtlBalancedNode TreeNode { get => ReadStructure<RtlBalancedNode>(nameof(TreeNode)); set => WriteStructure(nameof(TreeNode), value); }

        [Offset(0UL)]
        public Mipfnflink u1 { get => ReadStructure<Mipfnflink>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(8UL)]
        public IntPtr PteAddress { get => ReadHere<IntPtr>(nameof(PteAddress)); set => WriteHere(nameof(PteAddress), value); }

        [Offset(8UL)]
        public ulong PteLong { get => ReadHere<ulong>(nameof(PteLong)); set => WriteHere(nameof(PteLong), value); }

        [Offset(16UL)]
        public Mmpte OriginalPte { get => ReadStructure<Mmpte>(nameof(OriginalPte)); set => WriteStructure(nameof(OriginalPte), value); }

        [Offset(24UL)]
        public Mipfnblink u2 { get => ReadStructure<Mipfnblink>(nameof(u2)); set => WriteStructure(nameof(u2), value); }

        [Offset(32UL)]
        public UnnamedTag u3 { get => ReadStructure<UnnamedTag>(nameof(u3)); set => WriteStructure(nameof(u3), value); }

        [Offset(36UL)]
        public MiPfnFLAGS5 u5 { get => ReadStructure<MiPfnFLAGS5>(nameof(u5)); set => WriteStructure(nameof(u5), value); }

        [Offset(40UL)]
        public MiPfnFLAGS4 u4 { get => ReadStructure<MiPfnFLAGS4>(nameof(u4)); set => WriteStructure(nameof(u4), value); }

        public Mmpfn(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Mmpfn>();
        }
    }
}