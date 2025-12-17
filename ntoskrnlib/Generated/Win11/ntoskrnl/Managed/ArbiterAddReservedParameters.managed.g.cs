using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_ADD_RESERVED_PARAMETERS")]
    public sealed class ArbiterAddReservedParameters : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ReserveDevice { get => ReadHere<IntPtr>(nameof(ReserveDevice)); set => WriteHere(nameof(ReserveDevice), value); }

        public ArbiterAddReservedParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterAddReservedParameters>();
        }
    }
}