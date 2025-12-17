using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_PLATFORM_STATE_RESIDENCY")]
    public sealed class _PROCESSOR_PLATFORM_STATE_RESIDENCY : DynamicStructure
    {
        public ulong Residency { get; }
        public ulong TransitionCount { get; }

        public _PROCESSOR_PLATFORM_STATE_RESIDENCY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESSOR_PLATFORM_STATE_RESIDENCY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESSOR_PLATFORM_STATE_RESIDENCY.Residency),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESSOR_PLATFORM_STATE_RESIDENCY.TransitionCount),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PROCESSOR_PLATFORM_STATE_RESIDENCY>((mem, ptr) => new _PROCESSOR_PLATFORM_STATE_RESIDENCY(mem, ptr), offsets);
        }
    }
}