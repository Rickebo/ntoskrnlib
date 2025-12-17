using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_ACTIVE_COMPLETE")]
    public sealed class _PEP_WORK_ACTIVE_COMPLETE : DynamicStructure
    {
        public IntPtr DeviceHandle { get; }
        public uint Component { get; }

        public _PEP_WORK_ACTIVE_COMPLETE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_WORK_ACTIVE_COMPLETE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_WORK_ACTIVE_COMPLETE.DeviceHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_WORK_ACTIVE_COMPLETE.Component),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PEP_WORK_ACTIVE_COMPLETE>((mem, ptr) => new _PEP_WORK_ACTIVE_COMPLETE(mem, ptr), offsets);
        }
    }
}