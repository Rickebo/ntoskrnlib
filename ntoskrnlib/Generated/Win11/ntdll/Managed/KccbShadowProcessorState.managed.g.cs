using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KCCB_SHADOW_PROCESSOR_STATE")]
    public sealed class KccbShadowProcessorState : DynamicStructure
    {
        [Offset(0UL)]
        public byte Idle { get => ReadHere<byte>(nameof(Idle)); set => WriteHere(nameof(Idle), value); }

        [Offset(0UL)]
        public byte Transitioning { get => ReadHere<byte>(nameof(Transitioning)); set => WriteHere(nameof(Transitioning), value); }

        [Offset(0UL)]
        public byte AllState { get => ReadHere<byte>(nameof(AllState)); set => WriteHere(nameof(AllState), value); }

        public KccbShadowProcessorState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KccbShadowProcessorState>();
        }
    }
}