using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS")]
    public sealed class _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS : DynamicStructure
    {
        public byte FRUId { get; }
        public byte FRUText { get; }
        public byte Reserved { get; }
        public byte AsUCHAR { get; }

        public _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS.FRUId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS.FRUText),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS.AsUCHAR),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS>((mem, ptr) => new _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS(mem, ptr), offsets);
        }
    }
}