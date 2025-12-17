using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KHETERO_STATE")]
    public sealed class _KHETERO_STATE : DynamicStructure
    {
        public byte Qos { get; }
        public byte WorkloadClass { get; }
        public byte RunningType { get; }
        public byte AllFields { get; }

        public _KHETERO_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KHETERO_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KHETERO_STATE.Qos),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KHETERO_STATE.WorkloadClass),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KHETERO_STATE.RunningType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KHETERO_STATE.AllFields),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KHETERO_STATE>((mem, ptr) => new _KHETERO_STATE(mem, ptr), offsets);
        }
    }
}