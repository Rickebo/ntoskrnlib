using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_MITIGATION_OPTIONS_MAP")]
    public sealed class _PS_MITIGATION_OPTIONS_MAP : DynamicStructure
    {
        public ulong[] Map { get; }

        public _PS_MITIGATION_OPTIONS_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_MITIGATION_OPTIONS_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_MITIGATION_OPTIONS_MAP.Map),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PS_MITIGATION_OPTIONS_MAP>((mem, ptr) => new _PS_MITIGATION_OPTIONS_MAP(mem, ptr), offsets);
        }
    }
}