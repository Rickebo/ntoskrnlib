using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_DYNAMIC_ENFORCED_ADDRESS_RANGES")]
    public sealed class PsDynamicEnforcedAddressRanges : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTree Tree { get => ReadStructure<RtlAvlTree>(nameof(Tree)); set => WriteStructure(nameof(Tree), value); }

        [Offset(8UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        public PsDynamicEnforcedAddressRanges(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsDynamicEnforcedAddressRanges>();
        }
    }
}