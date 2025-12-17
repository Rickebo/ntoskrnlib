using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PS_TRUSTLET_CREATE_ATTRIBUTES")]
    public sealed class _PS_TRUSTLET_CREATE_ATTRIBUTES : DynamicStructure
    {
        public ulong TrustletIdentity { get; }
        public byte[] Attributes { get; }

        public _PS_TRUSTLET_CREATE_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_TRUSTLET_CREATE_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_TRUSTLET_CREATE_ATTRIBUTES.TrustletIdentity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_CREATE_ATTRIBUTES.Attributes),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PS_TRUSTLET_CREATE_ATTRIBUTES>((mem, ptr) => new _PS_TRUSTLET_CREATE_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}