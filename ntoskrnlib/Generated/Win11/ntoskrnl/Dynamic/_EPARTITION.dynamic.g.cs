using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EPARTITION")]
    public sealed class _EPARTITION : DynamicStructure
    {
        public IntPtr MmPartition { get; }
        public IntPtr CcPartition { get; }
        public IntPtr ExPartition { get; }
        public IntPtr SmPartition { get; }
        public IntPtr PfPartition { get; }
        public long HardReferenceCount { get; }
        public long OpenHandleCount { get; }
        public _LIST_ENTRY ActivePartitionLinks { get; }
        public IntPtr ParentPartition { get; }
        public _WORK_QUEUE_ITEM TeardownWorkItem { get; }
        public _EX_PUSH_LOCK TeardownLock { get; }
        public IntPtr SystemProcess { get; }
        public IntPtr SystemProcessHandle { get; }
        public uint PartitionFlags { get; }
        public uint PairedWithJob { get; }

        public _EPARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EPARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EPARTITION.MmPartition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EPARTITION.CcPartition),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EPARTITION.ExPartition),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EPARTITION.SmPartition),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EPARTITION.PfPartition),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_EPARTITION.HardReferenceCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_EPARTITION.OpenHandleCount),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_EPARTITION.ActivePartitionLinks),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EPARTITION.ParentPartition),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_EPARTITION.TeardownWorkItem),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_EPARTITION.TeardownLock),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_EPARTITION.SystemProcess),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_EPARTITION.SystemProcessHandle),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_EPARTITION.PartitionFlags),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_EPARTITION.PairedWithJob),
                    new ulong[]
                    {
                        136UL
                    }
                }
            };
            Register<_EPARTITION>((mem, ptr) => new _EPARTITION(mem, ptr), offsets);
        }
    }
}