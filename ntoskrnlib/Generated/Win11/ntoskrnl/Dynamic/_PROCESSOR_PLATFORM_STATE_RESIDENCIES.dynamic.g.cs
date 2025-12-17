using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_PLATFORM_STATE_RESIDENCIES")]
    public sealed class _PROCESSOR_PLATFORM_STATE_RESIDENCIES : DynamicStructure
    {
        public uint Count { get; }
        public byte[] States { get; }

        public _PROCESSOR_PLATFORM_STATE_RESIDENCIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESSOR_PLATFORM_STATE_RESIDENCIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESSOR_PLATFORM_STATE_RESIDENCIES.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESSOR_PLATFORM_STATE_RESIDENCIES.States),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PROCESSOR_PLATFORM_STATE_RESIDENCIES>((mem, ptr) => new _PROCESSOR_PLATFORM_STATE_RESIDENCIES(mem, ptr), offsets);
        }
    }
}