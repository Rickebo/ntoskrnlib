using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TRUSTLET_COLLABORATION_ID")]
    public sealed class TrustletCollaborationId : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray Value { get => ReadStructure<DynamicArray>(nameof(Value)); set => WriteStructure(nameof(Value), value); }

        public TrustletCollaborationId(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TrustletCollaborationId>();
        }
    }
}