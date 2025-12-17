using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPTE_SUBSECTION")]
    public sealed class MmpteSubsection : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Valid { get => ReadHere<ulong>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        [Offset(0UL)]
        public ulong Unused0 { get => ReadHere<ulong>(nameof(Unused0)); set => WriteHere(nameof(Unused0), value); }

        [Offset(0UL)]
        public ulong OnStandbyLookaside { get => ReadHere<ulong>(nameof(OnStandbyLookaside)); set => WriteHere(nameof(OnStandbyLookaside), value); }

        [Offset(0UL)]
        public ulong SwizzleBit { get => ReadHere<ulong>(nameof(SwizzleBit)); set => WriteHere(nameof(SwizzleBit), value); }

        [Offset(0UL)]
        public ulong Protection { get => ReadHere<ulong>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public ulong Prototype { get => ReadHere<ulong>(nameof(Prototype)); set => WriteHere(nameof(Prototype), value); }

        [Offset(0UL)]
        public ulong ColdPage { get => ReadHere<ulong>(nameof(ColdPage)); set => WriteHere(nameof(ColdPage), value); }

        [Offset(0UL)]
        public ulong Unused2 { get => ReadHere<ulong>(nameof(Unused2)); set => WriteHere(nameof(Unused2), value); }

        [Offset(0UL)]
        public ulong ExecutePrivilege { get => ReadHere<ulong>(nameof(ExecutePrivilege)); set => WriteHere(nameof(ExecutePrivilege), value); }

        [Offset(0UL)]
        public long SubsectionAddress { get => ReadHere<long>(nameof(SubsectionAddress)); set => WriteHere(nameof(SubsectionAddress), value); }

        public MmpteSubsection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpteSubsection>();
        }
    }
}