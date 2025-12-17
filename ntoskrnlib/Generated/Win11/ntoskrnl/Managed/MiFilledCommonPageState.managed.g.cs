using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_FILLED_COMMON_PAGE_STATE")]
    public sealed class MiFilledCommonPageState : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray PageFrameIndex { get => ReadStructure<DynamicArray>(nameof(PageFrameIndex)); set => WriteStructure(nameof(PageFrameIndex), value); }

        [Offset(32UL)]
        public IntPtr LeafMapping { get => ReadHere<IntPtr>(nameof(LeafMapping)); set => WriteHere(nameof(LeafMapping), value); }

        [Offset(40UL)]
        public ulong LeafCrc { get => ReadHere<ulong>(nameof(LeafCrc)); set => WriteHere(nameof(LeafCrc), value); }

        [Offset(48UL)]
        public Mmpte PdeContents { get => ReadStructure<Mmpte>(nameof(PdeContents)); set => WriteStructure(nameof(PdeContents), value); }

        public MiFilledCommonPageState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiFilledCommonPageState>();
        }
    }
}