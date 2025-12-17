using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HV_GET_BIN_CONTEXT")]
    public sealed class HvGetBinContext : DynamicStructure
    {
        [Offset(0UL)]
        public ushort OutstandingReference { get => ReadHere<ushort>(nameof(OutstandingReference)); set => WriteHere(nameof(OutstandingReference), value); }

        public HvGetBinContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HvGetBinContext>();
        }
    }
}