using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_POWER_CONTROL")]
    public sealed class _PEP_WORK_POWER_CONTROL : DynamicStructure
    {
        public IntPtr DeviceHandle { get; }
        public IntPtr PowerControlCode { get; }
        public IntPtr RequestContext { get; }
        public IntPtr InBuffer { get; }
        public ulong InBufferSize { get; }
        public IntPtr OutBuffer { get; }
        public ulong OutBufferSize { get; }

        public _PEP_WORK_POWER_CONTROL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_WORK_POWER_CONTROL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_WORK_POWER_CONTROL.DeviceHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_WORK_POWER_CONTROL.PowerControlCode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_POWER_CONTROL.RequestContext),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEP_WORK_POWER_CONTROL.InBuffer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEP_WORK_POWER_CONTROL.InBufferSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEP_WORK_POWER_CONTROL.OutBuffer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PEP_WORK_POWER_CONTROL.OutBufferSize),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_PEP_WORK_POWER_CONTROL>((mem, ptr) => new _PEP_WORK_POWER_CONTROL(mem, ptr), offsets);
        }
    }
}