using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_XSDT")]
    public sealed class _XSDT : DynamicStructure
    {
        public _DESCRIPTION_HEADER Header { get; }
        public byte[] Tables { get; }

        public _XSDT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XSDT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XSDT.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XSDT.Tables),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_XSDT>((mem, ptr) => new _XSDT(mem, ptr), offsets);
        }
    }
}