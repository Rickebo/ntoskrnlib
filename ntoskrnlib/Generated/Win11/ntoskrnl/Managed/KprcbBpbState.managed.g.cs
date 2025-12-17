using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPRCB_BPB_STATE")]
    public sealed class KprcbBpbState : DynamicStructure
    {
        [Offset(0UL)]
        public ushort CpuIdle { get => ReadHere<ushort>(nameof(CpuIdle)); set => WriteHere(nameof(CpuIdle), value); }

        [Offset(0UL)]
        public ushort FlushRsbOnTrap { get => ReadHere<ushort>(nameof(FlushRsbOnTrap)); set => WriteHere(nameof(FlushRsbOnTrap), value); }

        [Offset(0UL)]
        public ushort IbpbOnReturn { get => ReadHere<ushort>(nameof(IbpbOnReturn)); set => WriteHere(nameof(IbpbOnReturn), value); }

        [Offset(0UL)]
        public ushort IbpbOnTrap { get => ReadHere<ushort>(nameof(IbpbOnTrap)); set => WriteHere(nameof(IbpbOnTrap), value); }

        [Offset(0UL)]
        public ushort IbpbOnRetpolineExit { get => ReadHere<ushort>(nameof(IbpbOnRetpolineExit)); set => WriteHere(nameof(IbpbOnRetpolineExit), value); }

        [Offset(0UL)]
        public ushort FlushRsbOnReturn { get => ReadHere<ushort>(nameof(FlushRsbOnReturn)); set => WriteHere(nameof(FlushRsbOnReturn), value); }

        [Offset(0UL)]
        public ushort FlushRsbOnRetpolineExit { get => ReadHere<ushort>(nameof(FlushRsbOnRetpolineExit)); set => WriteHere(nameof(FlushRsbOnRetpolineExit), value); }

        [Offset(0UL)]
        public ushort FlushBhbOnTrap { get => ReadHere<ushort>(nameof(FlushBhbOnTrap)); set => WriteHere(nameof(FlushBhbOnTrap), value); }

        [Offset(0UL)]
        public ushort DivideOnReturn { get => ReadHere<ushort>(nameof(DivideOnReturn)); set => WriteHere(nameof(DivideOnReturn), value); }

        [Offset(0UL)]
        public ushort VerwOnNonKvaReturn { get => ReadHere<ushort>(nameof(VerwOnNonKvaReturn)); set => WriteHere(nameof(VerwOnNonKvaReturn), value); }

        [Offset(0UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public ushort AllFlags { get => ReadHere<ushort>(nameof(AllFlags)); set => WriteHere(nameof(AllFlags), value); }

        public KprcbBpbState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprcbBpbState>();
        }
    }
}