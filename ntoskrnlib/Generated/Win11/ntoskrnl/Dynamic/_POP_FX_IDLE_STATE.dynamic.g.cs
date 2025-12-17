using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_IDLE_STATE")]
    public sealed class _POP_FX_IDLE_STATE : DynamicStructure
    {
        public ulong TransitionLatency { get; }
        public ulong ResidencyRequirement { get; }
        public uint NominalPower { get; }

        public _POP_FX_IDLE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_IDLE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_IDLE_STATE.TransitionLatency),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_IDLE_STATE.ResidencyRequirement),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_IDLE_STATE.NominalPower),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_POP_FX_IDLE_STATE>((mem, ptr) => new _POP_FX_IDLE_STATE(mem, ptr), offsets);
        }
    }
}