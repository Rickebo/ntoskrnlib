using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POWER_LIMIT_VALUE")]
    public sealed class _POWER_LIMIT_VALUE : DynamicStructure
    {
        public uint Type { get; }
        public uint DomainId { get; }
        public uint TargetValue { get; }
        public uint TimeParameter { get; }

        public _POWER_LIMIT_VALUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POWER_LIMIT_VALUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POWER_LIMIT_VALUE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_VALUE.DomainId),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_VALUE.TargetValue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_VALUE.TimeParameter),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_POWER_LIMIT_VALUE>((mem, ptr) => new _POWER_LIMIT_VALUE(mem, ptr), offsets);
        }
    }
}