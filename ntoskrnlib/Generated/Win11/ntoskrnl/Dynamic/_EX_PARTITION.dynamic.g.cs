using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_PARTITION")]
    public sealed class _EX_PARTITION : DynamicStructure
    {
        public IntPtr PartitionObject { get; }
        public IntPtr WorkQueues { get; }
        public IntPtr WorkQueueManagers { get; }
        public int QueueAllocationMask { get; }

        public _EX_PARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_PARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_PARTITION.PartitionObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PARTITION.WorkQueues),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EX_PARTITION.WorkQueueManagers),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EX_PARTITION.QueueAllocationMask),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_EX_PARTITION>((mem, ptr) => new _EX_PARTITION(mem, ptr), offsets);
        }
    }
}