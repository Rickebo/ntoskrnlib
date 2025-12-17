using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LUID")]
    public sealed class _LUID : DynamicStructure
    {
        public uint LowPart { get; }
        public int HighPart { get; }

        public _LUID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LUID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LUID.LowPart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LUID.HighPart),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_LUID>((mem, ptr) => new _LUID(mem, ptr), offsets);
        }
    }
}