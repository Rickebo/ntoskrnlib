using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KHETERO_STATE")]
    public sealed class KheteroState : DynamicStructure
    {
        [Offset(0UL)]
        public byte Qos { get => ReadHere<byte>(nameof(Qos)); set => WriteHere(nameof(Qos), value); }

        [Offset(0UL)]
        public byte WorkloadClass { get => ReadHere<byte>(nameof(WorkloadClass)); set => WriteHere(nameof(WorkloadClass), value); }

        [Offset(0UL)]
        public byte RunningType { get => ReadHere<byte>(nameof(RunningType)); set => WriteHere(nameof(RunningType), value); }

        [Offset(0UL)]
        public byte AllFields { get => ReadHere<byte>(nameof(AllFields)); set => WriteHere(nameof(AllFields), value); }

        public KheteroState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KheteroState>();
        }
    }
}