using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RSDT_32")]
    public sealed class _RSDT_32 : DynamicStructure
    {
        public _DESCRIPTION_HEADER Header { get; }
        public uint[] Tables { get; }

        public _RSDT_32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RSDT_32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RSDT_32.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RSDT_32.Tables),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_RSDT_32>((mem, ptr) => new _RSDT_32(mem, ptr), offsets);
        }
    }
}