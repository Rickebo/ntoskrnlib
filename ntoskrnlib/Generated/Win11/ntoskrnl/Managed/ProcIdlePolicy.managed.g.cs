using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_IDLE_POLICY")]
    public sealed class ProcIdlePolicy : DynamicStructure
    {
        [Offset(0UL)]
        public byte PromotePercent { get => ReadHere<byte>(nameof(PromotePercent)); set => WriteHere(nameof(PromotePercent), value); }

        [Offset(1UL)]
        public byte DemotePercent { get => ReadHere<byte>(nameof(DemotePercent)); set => WriteHere(nameof(DemotePercent), value); }

        [Offset(2UL)]
        public byte PromotePercentBase { get => ReadHere<byte>(nameof(PromotePercentBase)); set => WriteHere(nameof(PromotePercentBase), value); }

        [Offset(3UL)]
        public byte DemotePercentBase { get => ReadHere<byte>(nameof(DemotePercentBase)); set => WriteHere(nameof(DemotePercentBase), value); }

        [Offset(4UL)]
        public byte AllowScaling { get => ReadHere<byte>(nameof(AllowScaling)); set => WriteHere(nameof(AllowScaling), value); }

        [Offset(5UL)]
        public byte ForceLightIdle { get => ReadHere<byte>(nameof(ForceLightIdle)); set => WriteHere(nameof(ForceLightIdle), value); }

        public ProcIdlePolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcIdlePolicy>();
        }
    }
}