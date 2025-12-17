using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_POWER_PLANE")]
    public sealed class _POP_POWER_PLANE : DynamicStructure
    {
        public _UNICODE_STRING PowerPlaneId { get; }
        public ulong Lock { get; }
        public byte OldIrql { get; }
        public int DevicePowerMw { get; }
        public IntPtr PmaxHandle { get; }
        public IntPtr NotifyDevicePowerDraw { get; }
        public ulong DeviceCount { get; }
        public IntPtr Devices { get; }

        public _POP_POWER_PLANE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_POWER_PLANE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_POWER_PLANE.PowerPlaneId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_POWER_PLANE.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_POWER_PLANE.OldIrql),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_POWER_PLANE.DevicePowerMw),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_POP_POWER_PLANE.PmaxHandle),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_POWER_PLANE.NotifyDevicePowerDraw),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_POWER_PLANE.DeviceCount),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_POWER_PLANE.Devices),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_POP_POWER_PLANE>((mem, ptr) => new _POP_POWER_PLANE(mem, ptr), offsets);
        }
    }
}