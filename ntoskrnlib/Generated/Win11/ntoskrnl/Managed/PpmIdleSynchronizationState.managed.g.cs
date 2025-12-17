using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_IDLE_SYNCHRONIZATION_STATE")]
    public sealed class PpmIdleSynchronizationState : DynamicStructure
    {
        [Offset(0UL)]
        public int AsLong { get => ReadHere<int>(nameof(AsLong)); set => WriteHere(nameof(AsLong), value); }

        [Offset(0UL)]
        public int RefCount { get => ReadHere<int>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(0UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        public PpmIdleSynchronizationState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmIdleSynchronizationState>();
        }
    }
}