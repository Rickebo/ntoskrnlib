using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_COMPONENT_POWER_PROFILE")]
    public sealed class _POP_COMPONENT_POWER_PROFILE : DynamicStructure
    {
        public _GUID ComponentGuid { get; }
        public IntPtr Device { get; }
        public ulong FxCount { get; }
        public byte[] FxPower { get; }

        public _POP_COMPONENT_POWER_PROFILE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_COMPONENT_POWER_PROFILE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_COMPONENT_POWER_PROFILE.ComponentGuid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_COMPONENT_POWER_PROFILE.Device),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_COMPONENT_POWER_PROFILE.FxCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_COMPONENT_POWER_PROFILE.FxPower),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_POP_COMPONENT_POWER_PROFILE>((mem, ptr) => new _POP_COMPONENT_POWER_PROFILE(mem, ptr), offsets);
        }
    }
}