using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LARGE_INTEGER")]
    public sealed class _LARGE_INTEGER : DynamicStructure
    {
        public uint LowPart { get; }
        public int HighPart { get; }
        public _unnamed_tag_ u { get; }
        public long QuadPart { get; }

        public _LARGE_INTEGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LARGE_INTEGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LARGE_INTEGER.LowPart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LARGE_INTEGER.HighPart),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LARGE_INTEGER.u),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LARGE_INTEGER.QuadPart),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_LARGE_INTEGER>((mem, ptr) => new _LARGE_INTEGER(mem, ptr), offsets);
        }
    }
}