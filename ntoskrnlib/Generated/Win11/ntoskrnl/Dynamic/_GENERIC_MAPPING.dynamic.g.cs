using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GENERIC_MAPPING")]
    public sealed class _GENERIC_MAPPING : DynamicStructure
    {
        public uint GenericRead { get; }
        public uint GenericWrite { get; }
        public uint GenericExecute { get; }
        public uint GenericAll { get; }

        public _GENERIC_MAPPING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GENERIC_MAPPING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GENERIC_MAPPING.GenericRead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GENERIC_MAPPING.GenericWrite),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_GENERIC_MAPPING.GenericExecute),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_GENERIC_MAPPING.GenericAll),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_GENERIC_MAPPING>((mem, ptr) => new _GENERIC_MAPPING(mem, ptr), offsets);
        }
    }
}