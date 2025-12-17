using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_STORAGE_SECURITY_COMPLIANCE_BITMASK")]
    public sealed class _STORAGE_SECURITY_COMPLIANCE_BITMASK : DynamicStructure
    {
        public byte FIPS { get; }
        public byte Reserved { get; }
        public byte AsUchar { get; }

        public _STORAGE_SECURITY_COMPLIANCE_BITMASK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STORAGE_SECURITY_COMPLIANCE_BITMASK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STORAGE_SECURITY_COMPLIANCE_BITMASK.FIPS),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_SECURITY_COMPLIANCE_BITMASK.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_SECURITY_COMPLIANCE_BITMASK.AsUchar),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_STORAGE_SECURITY_COMPLIANCE_BITMASK>((mem, ptr) => new _STORAGE_SECURITY_COMPLIANCE_BITMASK(mem, ptr), offsets);
        }
    }
}