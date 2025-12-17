using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_DEVICE_IDLE")]
    public sealed class _PEP_WORK_DEVICE_IDLE : DynamicStructure
    {
        public IntPtr DeviceHandle { get; }
        public byte IgnoreIdleTimeout { get; }

        public _PEP_WORK_DEVICE_IDLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_WORK_DEVICE_IDLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_WORK_DEVICE_IDLE.DeviceHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_WORK_DEVICE_IDLE.IgnoreIdleTimeout),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PEP_WORK_DEVICE_IDLE>((mem, ptr) => new _PEP_WORK_DEVICE_IDLE(mem, ptr), offsets);
        }
    }
}