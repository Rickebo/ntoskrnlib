using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_AVAILABLE_CPUS_WORK_ITEM")]
    public sealed class _KI_AVAILABLE_CPUS_WORK_ITEM : DynamicStructure
    {
        public _WORK_QUEUE_ITEM ExWorkItem { get; }
        public _EX_RUNDOWN_REF RundownRef { get; }
        public _KI_AVAILABLE_CPUS_WORK_STATE WorkState { get; }
        public IntPtr Callback { get; }
        public IntPtr Context { get; }

        public _KI_AVAILABLE_CPUS_WORK_ITEM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_AVAILABLE_CPUS_WORK_ITEM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_ITEM.ExWorkItem),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_ITEM.RundownRef),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_ITEM.WorkState),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_ITEM.Callback),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KI_AVAILABLE_CPUS_WORK_ITEM.Context),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_KI_AVAILABLE_CPUS_WORK_ITEM>((mem, ptr) => new _KI_AVAILABLE_CPUS_WORK_ITEM(mem, ptr), offsets);
        }
    }
}