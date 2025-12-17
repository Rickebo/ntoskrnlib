using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSYSTEM_TIME")]
    public sealed class _KSYSTEM_TIME : DynamicStructure
    {
        public uint LowPart { get; }
        public int High1Time { get; }
        public int High2Time { get; }

        public _KSYSTEM_TIME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSYSTEM_TIME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSYSTEM_TIME.LowPart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSYSTEM_TIME.High1Time),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KSYSTEM_TIME.High2Time),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KSYSTEM_TIME>((mem, ptr) => new _KSYSTEM_TIME(mem, ptr), offsets);
        }
    }
}