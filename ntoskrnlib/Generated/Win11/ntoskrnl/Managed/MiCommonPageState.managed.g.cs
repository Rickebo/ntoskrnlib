using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_COMMON_PAGE_STATE")]
    public sealed class MiCommonPageState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DummyPagePfn { get => ReadHere<IntPtr>(nameof(DummyPagePfn)); set => WriteHere(nameof(DummyPagePfn), value); }

        [Offset(8UL)]
        public ulong DummyPage { get => ReadHere<ulong>(nameof(DummyPage)); set => WriteHere(nameof(DummyPage), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray GapFrames { get => ReadStructure<DynamicArray>(nameof(GapFrames)); set => WriteStructure(nameof(GapFrames), value); }

        public MiCommonPageState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCommonPageState>();
        }
    }
}