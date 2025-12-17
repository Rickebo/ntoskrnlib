using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_FX_PERF_STATE_CHANGE")]
    public sealed class PoFxPerfStateChange : DynamicStructure
    {
        [Offset(0UL)]
        public uint Set { get => ReadHere<uint>(nameof(Set)); set => WriteHere(nameof(Set), value); }

        [Offset(8UL)]
        public uint StateIndex { get => ReadHere<uint>(nameof(StateIndex)); set => WriteHere(nameof(StateIndex), value); }

        [Offset(8UL)]
        public ulong StateValue { get => ReadHere<ulong>(nameof(StateValue)); set => WriteHere(nameof(StateValue), value); }

        public PoFxPerfStateChange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoFxPerfStateChange>();
        }
    }
}