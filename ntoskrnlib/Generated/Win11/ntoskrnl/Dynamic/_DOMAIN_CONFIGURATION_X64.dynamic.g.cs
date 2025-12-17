using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DOMAIN_CONFIGURATION_X64")]
    public sealed class _DOMAIN_CONFIGURATION_X64 : DynamicStructure
    {
        public _LARGE_INTEGER FirstLevelPageTableRoot { get; }
        public byte TranslationEnabled { get; }

        public _DOMAIN_CONFIGURATION_X64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DOMAIN_CONFIGURATION_X64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DOMAIN_CONFIGURATION_X64.FirstLevelPageTableRoot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DOMAIN_CONFIGURATION_X64.TranslationEnabled),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DOMAIN_CONFIGURATION_X64>((mem, ptr) => new _DOMAIN_CONFIGURATION_X64(mem, ptr), offsets);
        }
    }
}