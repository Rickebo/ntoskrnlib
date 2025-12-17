using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_ATTRIBUTE_DATA")]
    public sealed class _PS_TRUSTLET_ATTRIBUTE_DATA : DynamicStructure
    {
        public _PS_TRUSTLET_ATTRIBUTE_HEADER Header { get; }
        public ulong[] Data { get; }

        public _PS_TRUSTLET_ATTRIBUTE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_TRUSTLET_ATTRIBUTE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_DATA.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_DATA.Data),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PS_TRUSTLET_ATTRIBUTE_DATA>((mem, ptr) => new _PS_TRUSTLET_ATTRIBUTE_DATA(mem, ptr), offsets);
        }
    }
}