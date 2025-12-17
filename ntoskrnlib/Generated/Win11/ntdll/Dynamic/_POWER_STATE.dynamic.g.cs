using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_POWER_STATE")]
    public sealed class _POWER_STATE : DynamicStructure
    {
        public uint SystemState { get; }
        public uint DeviceState { get; }

        public _POWER_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POWER_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POWER_STATE.SystemState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POWER_STATE.DeviceState),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_POWER_STATE>((mem, ptr) => new _POWER_STATE(mem, ptr), offsets);
        }
    }
}