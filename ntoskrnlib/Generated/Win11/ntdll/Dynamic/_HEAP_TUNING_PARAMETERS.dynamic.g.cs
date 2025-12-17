using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_TUNING_PARAMETERS")]
    public sealed class _HEAP_TUNING_PARAMETERS : DynamicStructure
    {
        public uint CommittThresholdShift { get; }
        public ulong MaxPreCommittThreshold { get; }

        public _HEAP_TUNING_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_TUNING_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_TUNING_PARAMETERS.CommittThresholdShift),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_TUNING_PARAMETERS.MaxPreCommittThreshold),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_TUNING_PARAMETERS>((mem, ptr) => new _HEAP_TUNING_PARAMETERS(mem, ptr), offsets);
        }
    }
}