using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_CORE")]
    public sealed class _MI_PARTITION_CORE : DynamicStructure
    {
        public ushort PartitionId { get; }
        public _MI_PARTITION_FLAGS Flags { get; }
        public uint Signature { get; }
        public byte MemoryConfigurationChanged { get; }
        public IntPtr NodeInformation { get; }
        public _RTL_AVL_TREE PageRoot { get; }
        public IntPtr MemoryNodeRuns { get; }
        public _WORK_QUEUE_ITEM PfnUnmapWorkItem { get; }
        public ulong PfnUnmapCount { get; }
        public IntPtr MemoryRuns { get; }
        public _KEVENT ExitEvent { get; }
        public _KEVENT ConductorNeededEvent { get; }
        public byte[] SystemThreadHandles { get; }
        public IntPtr PartitionObject { get; }
        public _EX_PUSH_LOCK DynamicMemoryPushLock { get; }
        public int DynamicMemoryLock { get; }
        public byte PfnUnmapActive { get; }
        public _KEVENT TemporaryMemoryEvent { get; }
        public IntPtr RootDirectory { get; }
        public IntPtr KernelObjectsDirectory { get; }
        public byte[] MemoryEvents { get; }
        public byte[] MemoryEventHandles { get; }
        public ulong TotalHugeIoRanges { get; }
        public ulong NonChargedSecurePages { get; }
        public _SLIST_HEADER FreeKernelShadowStackCacheEntries { get; }
        public ulong KernelShadowStackPages { get; }

        public _MI_PARTITION_CORE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_CORE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_CORE.PartitionId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.Signature),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.MemoryConfigurationChanged),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.NodeInformation),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.PageRoot),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.MemoryNodeRuns),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.PfnUnmapWorkItem),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.PfnUnmapCount),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.MemoryRuns),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.ExitEvent),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.ConductorNeededEvent),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.SystemThreadHandles),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.PartitionObject),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.DynamicMemoryPushLock),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.DynamicMemoryLock),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.PfnUnmapActive),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.TemporaryMemoryEvent),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.RootDirectory),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.KernelObjectsDirectory),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.MemoryEvents),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.MemoryEventHandles),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.TotalHugeIoRanges),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.NonChargedSecurePages),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.FreeKernelShadowStackCacheEntries),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_MI_PARTITION_CORE.KernelShadowStackPages),
                    new ulong[]
                    {
                        464UL
                    }
                }
            };
            Register<_MI_PARTITION_CORE>((mem, ptr) => new _MI_PARTITION_CORE(mem, ptr), offsets);
        }
    }
}