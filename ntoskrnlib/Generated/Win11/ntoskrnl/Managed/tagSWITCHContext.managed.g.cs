using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!tagSWITCH_CONTEXT")]
    public sealed class tagSWITCHContext : DynamicStructure
    {
        [Offset(0UL)]
        public tagSWITCHContextAttribute Attribute { get => ReadStructure<tagSWITCHContextAttribute>(nameof(Attribute)); set => WriteStructure(nameof(Attribute), value); }

        [Offset(24UL)]
        public tagSWITCHContextData Data { get => ReadStructure<tagSWITCHContextData>(nameof(Data)); set => WriteStructure(nameof(Data), value); }

        public tagSWITCHContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<tagSWITCHContext>();
        }
    }
}