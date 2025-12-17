using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROCESS_EXTENDED_ENERGY_VALUES_V1")]
    public sealed class _PROCESS_EXTENDED_ENERGY_VALUES_V1 : DynamicStructure
    {
        public _PROCESS_ENERGY_VALUES Base { get; }
        public _PROCESS_ENERGY_VALUES_EXTENSION Extension { get; }
        public ulong NpuWorkUnits { get; }

        public _PROCESS_EXTENDED_ENERGY_VALUES_V1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESS_EXTENDED_ENERGY_VALUES_V1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESS_EXTENDED_ENERGY_VALUES_V1.Base),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXTENDED_ENERGY_VALUES_V1.Extension),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_PROCESS_EXTENDED_ENERGY_VALUES_V1.NpuWorkUnits),
                    new ulong[]
                    {
                        432UL
                    }
                }
            };
            Register<_PROCESS_EXTENDED_ENERGY_VALUES_V1>((mem, ptr) => new _PROCESS_EXTENDED_ENERGY_VALUES_V1(mem, ptr), offsets);
        }
    }
}