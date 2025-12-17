using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_DEVICE_POWER")]
    public sealed class _PEP_WORK_DEVICE_POWER : DynamicStructure
    {
        public IntPtr DeviceHandle { get; }
        public byte PowerRequired { get; }

        public _PEP_WORK_DEVICE_POWER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_WORK_DEVICE_POWER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_WORK_DEVICE_POWER.DeviceHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_WORK_DEVICE_POWER.PowerRequired),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PEP_WORK_DEVICE_POWER>((mem, ptr) => new _PEP_WORK_DEVICE_POWER(mem, ptr), offsets);
        }
    }
}