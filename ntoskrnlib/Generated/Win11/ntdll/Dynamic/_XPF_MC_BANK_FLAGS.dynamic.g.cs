using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_XPF_MC_BANK_FLAGS")]
    public sealed class _XPF_MC_BANK_FLAGS : DynamicStructure
    {
        public byte ClearOnInitializationRW { get; }
        public byte ControlDataRW { get; }
        public byte Reserved { get; }
        public byte AsUCHAR { get; }

        public _XPF_MC_BANK_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XPF_MC_BANK_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XPF_MC_BANK_FLAGS.ClearOnInitializationRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XPF_MC_BANK_FLAGS.ControlDataRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XPF_MC_BANK_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XPF_MC_BANK_FLAGS.AsUCHAR),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_XPF_MC_BANK_FLAGS>((mem, ptr) => new _XPF_MC_BANK_FLAGS(mem, ptr), offsets);
        }
    }
}