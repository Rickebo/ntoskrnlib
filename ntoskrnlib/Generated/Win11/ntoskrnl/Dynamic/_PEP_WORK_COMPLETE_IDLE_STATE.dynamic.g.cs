using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_COMPLETE_IDLE_STATE")]
    public sealed class _PEP_WORK_COMPLETE_IDLE_STATE : DynamicStructure
    {
        public IntPtr DeviceHandle { get; }
        public uint Component { get; }

        public _PEP_WORK_COMPLETE_IDLE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_WORK_COMPLETE_IDLE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_WORK_COMPLETE_IDLE_STATE.DeviceHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_WORK_COMPLETE_IDLE_STATE.Component),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PEP_WORK_COMPLETE_IDLE_STATE>((mem, ptr) => new _PEP_WORK_COMPLETE_IDLE_STATE(mem, ptr), offsets);
        }
    }
}