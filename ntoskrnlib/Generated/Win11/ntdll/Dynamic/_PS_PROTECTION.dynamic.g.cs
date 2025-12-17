using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_PROTECTION")]
    public sealed class _PS_PROTECTION : DynamicStructure
    {
        public byte Level { get; }
        public byte Type { get; }
        public byte Audit { get; }
        public byte Signer { get; }

        public _PS_PROTECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_PROTECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_PROTECTION.Level),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_PROTECTION.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_PROTECTION.Audit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_PROTECTION.Signer),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PS_PROTECTION>((mem, ptr) => new _PS_PROTECTION(mem, ptr), offsets);
        }
    }
}