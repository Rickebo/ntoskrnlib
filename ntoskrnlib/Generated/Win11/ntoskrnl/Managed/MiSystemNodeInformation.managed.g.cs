using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_NODE_INFORMATION")]
    public sealed class MiSystemNodeInformation : DynamicStructure
    {
        [Offset(0UL)]
        public MiSystemNodeAffinityInformation Affinities { get => ReadStructure<MiSystemNodeAffinityInformation>(nameof(Affinities)); set => WriteStructure(nameof(Affinities), value); }

        [Offset(32UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(44UL)]
        public MiNodeNumberZeroBased ProcessorNode { get => ReadStructure<MiNodeNumberZeroBased>(nameof(ProcessorNode)); set => WriteStructure(nameof(ProcessorNode), value); }

        [Offset(48UL)]
        public GroupAffinity ForwardProgressGroupAffinity { get => ReadStructure<GroupAffinity>(nameof(ForwardProgressGroupAffinity)); set => WriteStructure(nameof(ForwardProgressGroupAffinity), value); }

        [Offset(64UL)]
        public int LargePageListOpLock { get => ReadHere<int>(nameof(LargePageListOpLock)); set => WriteHere(nameof(LargePageListOpLock), value); }

        [Offset(72UL)]
        [Length(3)]
        public DynamicArray WriteCalibration { get => ReadStructure<DynamicArray>(nameof(WriteCalibration)); set => WriteStructure(nameof(WriteCalibration), value); }

        [Offset(576UL)]
        [Length(2)]
        public DynamicArray MaximumBandwidth { get => ReadStructure<DynamicArray>(nameof(MaximumBandwidth)); set => WriteStructure(nameof(MaximumBandwidth), value); }

        [Offset(640UL)]
        public int IoPfnLock { get => ReadHere<int>(nameof(IoPfnLock)); set => WriteHere(nameof(IoPfnLock), value); }

        [Offset(648UL)]
        [Length(4)]
        public DynamicArray DeferredPfnsToFree { get => ReadStructure<DynamicArray>(nameof(DeferredPfnsToFree)); set => WriteStructure(nameof(DeferredPfnsToFree), value); }

        [Offset(776UL)]
        public MiDeferredPfnsToFree DeferredPfnsReady { get => ReadStructure<MiDeferredPfnsToFree>(nameof(DeferredPfnsReady)); set => WriteStructure(nameof(DeferredPfnsReady), value); }

        [Offset(808UL)]
        public int DeferredPfnsToFreeLock { get => ReadHere<int>(nameof(DeferredPfnsToFreeLock)); set => WriteHere(nameof(DeferredPfnsToFreeLock), value); }

        public MiSystemNodeInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemNodeInformation>();
        }
    }
}