using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_ERROR_RECORD")]
    public sealed class _WHEA_ERROR_RECORD : DynamicStructure
    {
        public _WHEA_ERROR_RECORD_HEADER Header { get; }
        public byte[] SectionDescriptor { get; }

        public _WHEA_ERROR_RECORD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_RECORD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_RECORD.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD.SectionDescriptor),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_WHEA_ERROR_RECORD>((mem, ptr) => new _WHEA_ERROR_RECORD(mem, ptr), offsets);
        }
    }
}