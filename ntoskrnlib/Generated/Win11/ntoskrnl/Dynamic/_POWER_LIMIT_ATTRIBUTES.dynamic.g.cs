using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POWER_LIMIT_ATTRIBUTES")]
    public sealed class _POWER_LIMIT_ATTRIBUTES : DynamicStructure
    {
        public uint Type { get; }
        public uint DomainId { get; }
        public uint MaxValue { get; }
        public uint MinValue { get; }
        public uint MinTimeParameter { get; }
        public uint MaxTimeParameter { get; }
        public uint DefaultACValue { get; }
        public uint DefaultDCValue { get; }
        public _unnamed_tag_ Flags { get; }

        public _POWER_LIMIT_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POWER_LIMIT_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.DomainId),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.MaxValue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.MinValue),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.MinTimeParameter),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.MaxTimeParameter),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.DefaultACValue),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.DefaultDCValue),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_ATTRIBUTES.Flags),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_POWER_LIMIT_ATTRIBUTES>((mem, ptr) => new _POWER_LIMIT_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}