using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SECTION_WOW_STATE")]
    public sealed class MiSectionWowState : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBitmapEx ImageBitMap { get => ReadStructure<RtlBitmapEx>(nameof(ImageBitMap)); set => WriteStructure(nameof(ImageBitMap), value); }

        [Offset(16UL)]
        public MiDllOverflowArea OverflowArea { get => ReadStructure<MiDllOverflowArea>(nameof(OverflowArea)); set => WriteStructure(nameof(OverflowArea), value); }

        [Offset(48UL)]
        public IntPtr CfgBitMapSection { get => ReadHere<IntPtr>(nameof(CfgBitMapSection)); set => WriteHere(nameof(CfgBitMapSection), value); }

        [Offset(56UL)]
        public IntPtr CfgBitMapControlArea { get => ReadHere<IntPtr>(nameof(CfgBitMapControlArea)); set => WriteHere(nameof(CfgBitMapControlArea), value); }

        public MiSectionWowState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSectionWowState>();
        }
    }
}