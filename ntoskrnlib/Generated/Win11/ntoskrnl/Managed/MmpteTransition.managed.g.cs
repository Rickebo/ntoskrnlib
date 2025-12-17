using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPTE_TRANSITION")]
    public sealed class MmpteTransition : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Valid { get => ReadHere<ulong>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        [Offset(0UL)]
        public ulong Write { get => ReadHere<ulong>(nameof(Write)); set => WriteHere(nameof(Write), value); }

        [Offset(0UL)]
        public ulong OnStandbyLookaside { get => ReadHere<ulong>(nameof(OnStandbyLookaside)); set => WriteHere(nameof(OnStandbyLookaside), value); }

        [Offset(0UL)]
        public ulong IoTracker { get => ReadHere<ulong>(nameof(IoTracker)); set => WriteHere(nameof(IoTracker), value); }

        [Offset(0UL)]
        public ulong SwizzleBit { get => ReadHere<ulong>(nameof(SwizzleBit)); set => WriteHere(nameof(SwizzleBit), value); }

        [Offset(0UL)]
        public ulong Protection { get => ReadHere<ulong>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public ulong Prototype { get => ReadHere<ulong>(nameof(Prototype)); set => WriteHere(nameof(Prototype), value); }

        [Offset(0UL)]
        public ulong Transition { get => ReadHere<ulong>(nameof(Transition)); set => WriteHere(nameof(Transition), value); }

        [Offset(0UL)]
        public ulong PageFrameNumber { get => ReadHere<ulong>(nameof(PageFrameNumber)); set => WriteHere(nameof(PageFrameNumber), value); }

        [Offset(0UL)]
        public ulong Unused { get => ReadHere<ulong>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        public MmpteTransition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpteTransition>();
        }
    }
}