using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KCPU_PARTITION")]
    public sealed class _KCPU_PARTITION : DynamicStructure
    {
        public IntPtr Affinity { get; }
        public ulong Lock { get; }
        public _LIST_ENTRY ProcessList { get; }
        public IntPtr CpuPartitionObject { get; }
        public _KI_AVAILABLE_CPUS_WORK_ITEM AvailableCpusNotificationWorkItem { get; }
        public uint Flags { get; }

        public _KCPU_PARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCPU_PARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KCPU_PARTITION.Affinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCPU_PARTITION.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KCPU_PARTITION.ProcessList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KCPU_PARTITION.CpuPartitionObject),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KCPU_PARTITION.AvailableCpusNotificationWorkItem),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KCPU_PARTITION.Flags),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_KCPU_PARTITION>((mem, ptr) => new _KCPU_PARTITION(mem, ptr), offsets);
        }
    }
}