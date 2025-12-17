using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INPUT_MAPPING_ELEMENT")]
    public sealed class InputMappingElement : DynamicStructure
    {
        [Offset(0UL)]
        public uint InputMappingId { get => ReadHere<uint>(nameof(InputMappingId)); set => WriteHere(nameof(InputMappingId), value); }

        public InputMappingElement(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InputMappingElement>();
        }
    }
}