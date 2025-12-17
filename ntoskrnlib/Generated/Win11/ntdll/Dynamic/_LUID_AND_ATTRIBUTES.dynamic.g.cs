using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_LUID_AND_ATTRIBUTES")]
    public sealed class _LUID_AND_ATTRIBUTES : DynamicStructure
    {
        public _LUID Luid { get; }
        public uint Attributes { get; }

        public _LUID_AND_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LUID_AND_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LUID_AND_ATTRIBUTES.Luid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LUID_AND_ATTRIBUTES.Attributes),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_LUID_AND_ATTRIBUTES>((mem, ptr) => new _LUID_AND_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}