using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SID_IDENTIFIER_AUTHORITY")]
    public sealed class SidIdentifierAuthority : DynamicStructure
    {
        [Offset(0UL)]
        [Length(6)]
        public DynamicArray Value { get => ReadStructure<DynamicArray>(nameof(Value)); set => WriteStructure(nameof(Value), value); }

        public SidIdentifierAuthority(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SidIdentifierAuthority>();
        }
    }
}