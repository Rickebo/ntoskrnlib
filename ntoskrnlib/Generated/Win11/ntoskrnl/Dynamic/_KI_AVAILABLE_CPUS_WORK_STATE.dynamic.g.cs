using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_AVAILABLE_CPUS_WORK_STATE")]
    public sealed class _KI_AVAILABLE_CPUS_WORK_STATE : DynamicStructure
    {
        public uint WorkerExecuting { get; }
        public uint WorkPresent { get; }
        public uint Reserved { get; }
        public uint AllFields { get; }

        public _KI_AVAILABLE_CPUS_WORK_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_AVAILABLE_CPUS_WORK_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_STATE.WorkerExecuting),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_STATE.WorkPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_STATE.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_STATE.AllFields),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KI_AVAILABLE_CPUS_WORK_STATE>((mem, ptr) => new _KI_AVAILABLE_CPUS_WORK_STATE(mem, ptr), offsets);
        }
    }
}