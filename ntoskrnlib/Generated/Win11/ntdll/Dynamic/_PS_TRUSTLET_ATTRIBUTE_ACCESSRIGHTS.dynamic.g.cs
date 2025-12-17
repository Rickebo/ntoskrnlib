using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS")]
    public sealed class _PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS : DynamicStructure
    {
        public byte Trustlet { get; }
        public byte Ntos { get; }
        public byte WriteHandle { get; }
        public byte ReadHandle { get; }
        public byte Reserved { get; }
        public byte AccessRights { get; }

        public _PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS.Trustlet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS.Ntos),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS.WriteHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS.ReadHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS.AccessRights),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS>((mem, ptr) => new _PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS(mem, ptr), offsets);
        }
    }
}