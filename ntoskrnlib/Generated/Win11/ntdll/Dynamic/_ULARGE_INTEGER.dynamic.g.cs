using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ULARGE_INTEGER")]
    public sealed class _ULARGE_INTEGER : DynamicStructure
    {
        public uint LowPart { get; }
        public uint HighPart { get; }
        public _unnamed_tag_ u { get; }
        public ulong QuadPart { get; }

        public _ULARGE_INTEGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ULARGE_INTEGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ULARGE_INTEGER.LowPart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ULARGE_INTEGER.HighPart),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ULARGE_INTEGER.u),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ULARGE_INTEGER.QuadPart),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ULARGE_INTEGER>((mem, ptr) => new _ULARGE_INTEGER(mem, ptr), offsets);
        }
    }
}