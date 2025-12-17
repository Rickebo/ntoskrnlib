using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KCCB_SHADOW_PROCESSOR_STATE")]
    public sealed class _KCCB_SHADOW_PROCESSOR_STATE : DynamicStructure
    {
        public byte Idle { get; }
        public byte Transitioning { get; }
        public byte AllState { get; }

        public _KCCB_SHADOW_PROCESSOR_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCCB_SHADOW_PROCESSOR_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KCCB_SHADOW_PROCESSOR_STATE.Idle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCCB_SHADOW_PROCESSOR_STATE.Transitioning),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCCB_SHADOW_PROCESSOR_STATE.AllState),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KCCB_SHADOW_PROCESSOR_STATE>((mem, ptr) => new _KCCB_SHADOW_PROCESSOR_STATE(mem, ptr), offsets);
        }
    }
}