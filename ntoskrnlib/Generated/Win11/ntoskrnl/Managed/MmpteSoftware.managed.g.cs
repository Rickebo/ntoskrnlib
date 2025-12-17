using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPTE_SOFTWARE")]
    public sealed class MmpteSoftware : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Valid { get => ReadHere<ulong>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        [Offset(0UL)]
        public ulong PageFileReserved { get => ReadHere<ulong>(nameof(PageFileReserved)); set => WriteHere(nameof(PageFileReserved), value); }

        [Offset(0UL)]
        public ulong PageFileAllocated { get => ReadHere<ulong>(nameof(PageFileAllocated)); set => WriteHere(nameof(PageFileAllocated), value); }

        [Offset(0UL)]
        public ulong ColdPage { get => ReadHere<ulong>(nameof(ColdPage)); set => WriteHere(nameof(ColdPage), value); }

        [Offset(0UL)]
        public ulong SwizzleBit { get => ReadHere<ulong>(nameof(SwizzleBit)); set => WriteHere(nameof(SwizzleBit), value); }

        [Offset(0UL)]
        public ulong Protection { get => ReadHere<ulong>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public ulong Prototype { get => ReadHere<ulong>(nameof(Prototype)); set => WriteHere(nameof(Prototype), value); }

        [Offset(0UL)]
        public ulong Transition { get => ReadHere<ulong>(nameof(Transition)); set => WriteHere(nameof(Transition), value); }

        [Offset(0UL)]
        public ulong PageFileLow { get => ReadHere<ulong>(nameof(PageFileLow)); set => WriteHere(nameof(PageFileLow), value); }

        [Offset(0UL)]
        public ulong UsedPageTableEntries { get => ReadHere<ulong>(nameof(UsedPageTableEntries)); set => WriteHere(nameof(UsedPageTableEntries), value); }

        [Offset(0UL)]
        public ulong ShadowStack { get => ReadHere<ulong>(nameof(ShadowStack)); set => WriteHere(nameof(ShadowStack), value); }

        [Offset(0UL)]
        public ulong OnStandbyLookaside { get => ReadHere<ulong>(nameof(OnStandbyLookaside)); set => WriteHere(nameof(OnStandbyLookaside), value); }

        [Offset(0UL)]
        public ulong Unused { get => ReadHere<ulong>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        [Offset(0UL)]
        public ulong PageFileHigh { get => ReadHere<ulong>(nameof(PageFileHigh)); set => WriteHere(nameof(PageFileHigh), value); }

        public MmpteSoftware(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpteSoftware>();
        }
    }
}