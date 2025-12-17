using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_BOOT_ALLOCATION_PARAMETERS")]
    public sealed class ArbiterBootAllocationParameters : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ArbitrationList { get => ReadHere<IntPtr>(nameof(ArbitrationList)); set => WriteHere(nameof(ArbitrationList), value); }

        public ArbiterBootAllocationParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterBootAllocationParameters>();
        }
    }
}