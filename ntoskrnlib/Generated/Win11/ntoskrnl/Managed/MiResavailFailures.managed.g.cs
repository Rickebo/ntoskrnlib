using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_RESAVAIL_FAILURES")]
    public sealed class MiResavailFailures : DynamicStructure
    {
        [Offset(0UL)]
        public uint Wrap { get => ReadHere<uint>(nameof(Wrap)); set => WriteHere(nameof(Wrap), value); }

        [Offset(4UL)]
        public uint NoCharge { get => ReadHere<uint>(nameof(NoCharge)); set => WriteHere(nameof(NoCharge), value); }

        public MiResavailFailures(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiResavailFailures>();
        }
    }
}