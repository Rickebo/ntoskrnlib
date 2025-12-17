using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_QUAD")]
    public sealed class _QUAD : DynamicStructure
    {
        public long UseThisFieldToCopy { get; }
        public long DoNotUseThisField { get; }

        public _QUAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _QUAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_QUAD.UseThisFieldToCopy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_QUAD.DoNotUseThisField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_QUAD>((mem, ptr) => new _QUAD(mem, ptr), offsets);
        }
    }
}