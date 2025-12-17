using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INPUT_MAPPING_ELEMENT")]
    public sealed class _INPUT_MAPPING_ELEMENT : DynamicStructure
    {
        public uint InputMappingId { get; }

        public _INPUT_MAPPING_ELEMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INPUT_MAPPING_ELEMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INPUT_MAPPING_ELEMENT.InputMappingId),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_INPUT_MAPPING_ELEMENT>((mem, ptr) => new _INPUT_MAPPING_ELEMENT(mem, ptr), offsets);
        }
    }
}