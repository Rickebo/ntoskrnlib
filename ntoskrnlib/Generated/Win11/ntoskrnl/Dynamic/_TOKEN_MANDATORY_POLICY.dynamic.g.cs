using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TOKEN_MANDATORY_POLICY")]
    public sealed class _TOKEN_MANDATORY_POLICY : DynamicStructure
    {
        public uint Policy { get; }

        public _TOKEN_MANDATORY_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TOKEN_MANDATORY_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TOKEN_MANDATORY_POLICY.Policy),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TOKEN_MANDATORY_POLICY>((mem, ptr) => new _TOKEN_MANDATORY_POLICY(mem, ptr), offsets);
        }
    }
}