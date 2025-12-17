using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_DEVICE_POWER_PROFILE")]
    public sealed class _POP_DEVICE_POWER_PROFILE : DynamicStructure
    {
        public _UNICODE_STRING DeviceId { get; }
        public IntPtr PowerPlane { get; }
        public IntPtr FxDevice { get; }
        public int PowerDrawMw { get; }
        public byte[] DxPower { get; }
        public ulong ComponentCount { get; }
        public IntPtr Components { get; }

        public _POP_DEVICE_POWER_PROFILE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_DEVICE_POWER_PROFILE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_DEVICE_POWER_PROFILE.DeviceId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_DEVICE_POWER_PROFILE.PowerPlane),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_DEVICE_POWER_PROFILE.FxDevice),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_DEVICE_POWER_PROFILE.PowerDrawMw),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_DEVICE_POWER_PROFILE.DxPower),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_POP_DEVICE_POWER_PROFILE.ComponentCount),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_DEVICE_POWER_PROFILE.Components),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_POP_DEVICE_POWER_PROFILE>((mem, ptr) => new _POP_DEVICE_POWER_PROFILE(mem, ptr), offsets);
        }
    }
}