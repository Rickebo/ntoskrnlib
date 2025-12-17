using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_POWER_PLANE_PROFILE")]
    public sealed class _PO_POWER_PLANE_PROFILE : DynamicStructure
    {
        public uint ExclusivePowerMw { get; }
        public uint PeakPowerMw { get; }

        public _PO_POWER_PLANE_PROFILE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_POWER_PLANE_PROFILE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_POWER_PLANE_PROFILE.ExclusivePowerMw),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_POWER_PLANE_PROFILE.PeakPowerMw),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_PO_POWER_PLANE_PROFILE>((mem, ptr) => new _PO_POWER_PLANE_PROFILE(mem, ptr), offsets);
        }
    }
}