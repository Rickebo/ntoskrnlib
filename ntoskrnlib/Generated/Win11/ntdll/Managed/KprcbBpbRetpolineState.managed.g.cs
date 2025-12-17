using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KPRCB_BPB_RETPOLINE_STATE")]
    public sealed class KprcbBpbRetpolineState : DynamicStructure
    {
        [Offset(0UL)]
        public byte RunningNonRetpolineCode { get => ReadHere<byte>(nameof(RunningNonRetpolineCode)); set => WriteHere(nameof(RunningNonRetpolineCode), value); }

        [Offset(0UL)]
        public byte IndirectCallsSafe { get => ReadHere<byte>(nameof(IndirectCallsSafe)); set => WriteHere(nameof(IndirectCallsSafe), value); }

        [Offset(0UL)]
        public byte RetpolineEnabled { get => ReadHere<byte>(nameof(RetpolineEnabled)); set => WriteHere(nameof(RetpolineEnabled), value); }

        [Offset(0UL)]
        public byte RetpolineStateReserved { get => ReadHere<byte>(nameof(RetpolineStateReserved)); set => WriteHere(nameof(RetpolineStateReserved), value); }

        [Offset(0UL)]
        public byte AllFlags { get => ReadHere<byte>(nameof(AllFlags)); set => WriteHere(nameof(AllFlags), value); }

        public KprcbBpbRetpolineState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprcbBpbRetpolineState>();
        }
    }
}