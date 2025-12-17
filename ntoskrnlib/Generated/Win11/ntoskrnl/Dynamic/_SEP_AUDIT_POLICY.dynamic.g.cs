using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_AUDIT_POLICY")]
    public sealed class _SEP_AUDIT_POLICY : DynamicStructure
    {
        public _TOKEN_AUDIT_POLICY AdtTokenPolicy { get; }
        public byte PolicySetStatus { get; }

        public _SEP_AUDIT_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_AUDIT_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_AUDIT_POLICY.AdtTokenPolicy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_AUDIT_POLICY.PolicySetStatus),
                    new ulong[]
                    {
                        31UL
                    }
                }
            };
            Register<_SEP_AUDIT_POLICY>((mem, ptr) => new _SEP_AUDIT_POLICY(mem, ptr), offsets);
        }
    }
}