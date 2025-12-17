using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_STATE")]
    public sealed class MiCombineState : DynamicStructure
    {
        [Offset(0UL)]
        public int ActiveSpinLock { get => ReadHere<int>(nameof(ActiveSpinLock)); set => WriteHere(nameof(ActiveSpinLock), value); }

        [Offset(4UL)]
        public uint CombiningThreadCount { get => ReadHere<uint>(nameof(CombiningThreadCount)); set => WriteHere(nameof(CombiningThreadCount), value); }

        [Offset(8UL)]
        public RtlAvlTree ActiveThreadTree { get => ReadStructure<RtlAvlTree>(nameof(ActiveThreadTree)); set => WriteStructure(nameof(ActiveThreadTree), value); }

        [Offset(16UL)]
        public ulong CommonPageCombineDomain { get => ReadHere<ulong>(nameof(CommonPageCombineDomain)); set => WriteHere(nameof(CommonPageCombineDomain), value); }

        [Offset(24UL)]
        public uint CommonCombineDomainAssigned { get => ReadHere<uint>(nameof(CommonCombineDomainAssigned)); set => WriteHere(nameof(CommonCombineDomainAssigned), value); }

        [Offset(28UL)]
        public int CombineSequence { get => ReadHere<int>(nameof(CombineSequence)); set => WriteHere(nameof(CombineSequence), value); }

        public MiCombineState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCombineState>();
        }
    }
}