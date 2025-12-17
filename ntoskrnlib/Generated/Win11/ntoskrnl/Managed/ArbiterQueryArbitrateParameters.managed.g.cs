using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_QUERY_ARBITRATE_PARAMETERS")]
    public sealed class ArbiterQueryArbitrateParameters : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ArbitrationList { get => ReadHere<IntPtr>(nameof(ArbitrationList)); set => WriteHere(nameof(ArbitrationList), value); }

        public ArbiterQueryArbitrateParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterQueryArbitrateParameters>();
        }
    }
}