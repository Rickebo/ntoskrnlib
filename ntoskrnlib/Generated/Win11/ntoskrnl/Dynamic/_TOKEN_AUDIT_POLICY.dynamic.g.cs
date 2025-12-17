using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TOKEN_AUDIT_POLICY")]
    public sealed class _TOKEN_AUDIT_POLICY : DynamicStructure
    {
        public byte[] PerUserPolicy { get; }

        public _TOKEN_AUDIT_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TOKEN_AUDIT_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TOKEN_AUDIT_POLICY.PerUserPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TOKEN_AUDIT_POLICY>((mem, ptr) => new _TOKEN_AUDIT_POLICY(mem, ptr), offsets);
        }
    }
}