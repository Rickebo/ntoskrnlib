using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_XPF_MCE_FLAGS")]
    public sealed class _XPF_MCE_FLAGS : DynamicStructure
    {
        public uint MCG_CapabilityRW { get; }
        public uint MCG_GlobalControlRW { get; }
        public uint Reserved { get; }
        public uint AsULONG { get; }

        public _XPF_MCE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XPF_MCE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XPF_MCE_FLAGS.MCG_CapabilityRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XPF_MCE_FLAGS.MCG_GlobalControlRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XPF_MCE_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XPF_MCE_FLAGS.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_XPF_MCE_FLAGS>((mem, ptr) => new _XPF_MCE_FLAGS(mem, ptr), offsets);
        }
    }
}