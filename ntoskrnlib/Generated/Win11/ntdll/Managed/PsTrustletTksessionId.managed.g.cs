using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_TKSESSION_ID")]
    public sealed class PsTrustletTksessionId : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray SessionId { get => ReadStructure<DynamicArray>(nameof(SessionId)); set => WriteStructure(nameof(SessionId), value); }

        public PsTrustletTksessionId(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsTrustletTksessionId>();
        }
    }
}