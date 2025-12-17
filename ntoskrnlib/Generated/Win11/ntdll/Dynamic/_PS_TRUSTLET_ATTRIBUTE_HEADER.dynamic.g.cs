using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_ATTRIBUTE_HEADER")]
    public sealed class _PS_TRUSTLET_ATTRIBUTE_HEADER : DynamicStructure
    {
        public _PS_TRUSTLET_ATTRIBUTE_TYPE AttributeType { get; }
        public uint InstanceNumber { get; }
        public uint Reserved { get; }

        public _PS_TRUSTLET_ATTRIBUTE_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_TRUSTLET_ATTRIBUTE_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_HEADER.AttributeType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_HEADER.InstanceNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_HEADER.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_PS_TRUSTLET_ATTRIBUTE_HEADER>((mem, ptr) => new _PS_TRUSTLET_ATTRIBUTE_HEADER(mem, ptr), offsets);
        }
    }
}