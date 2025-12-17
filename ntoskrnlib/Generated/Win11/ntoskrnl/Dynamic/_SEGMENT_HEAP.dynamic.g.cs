using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEGMENT_HEAP")]
    public sealed class _SEGMENT_HEAP : DynamicStructure
    {
        public RTL_HP_ENV_HANDLE EnvHandle { get; }
        public uint Signature { get; }
        public uint GlobalFlags { get; }
        public uint Interceptor { get; }
        public ushort ProcessHeapListIndex { get; }
        public ushort AllocatedFromMetadata { get; }
        public ushort ReadOnly { get; }
        public ushort InternalFlags { get; }
        public _RTLP_HEAP_COMMIT_LIMIT_DATA CommitLimitData { get; }
        public ulong ReservedMustBeZero { get; }
        public IntPtr UserContext { get; }
        public ulong LargeMetadataLock { get; }
        public _RTL_RB_TREE LargeAllocMetadata { get; }
        public ulong LargeReservedPages { get; }
        public ulong LargeCommittedPages { get; }
        public ulong Tag { get; }
        public _RTL_RUN_ONCE StackTraceInitVar { get; }
        public _HEAP_RUNTIME_MEMORY_STATS MemStats { get; }
        public uint GlobalLockOwner { get; }
        public ulong ContextExtendLock { get; }
        public IntPtr AllocatedBase { get; }
        public IntPtr UncommittedBase { get; }
        public IntPtr ReservedLimit { get; }
        public IntPtr ReservedRegionEnd { get; }
        public _RTL_HP_HEAP_VA_CALLBACKS_ENCODED CallbacksEncoded { get; }
        public byte[] SegContexts { get; }
        public _HEAP_VS_CONTEXT VsContext { get; }
        public _HEAP_LFH_CONTEXT LfhContext { get; }

        public _SEGMENT_HEAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEGMENT_HEAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEGMENT_HEAP.EnvHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.Signature),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.GlobalFlags),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.Interceptor),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.ProcessHeapListIndex),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.AllocatedFromMetadata),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.ReadOnly),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.InternalFlags),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.CommitLimitData),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.ReservedMustBeZero),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.UserContext),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.LargeMetadataLock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.LargeAllocMetadata),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.LargeReservedPages),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.LargeCommittedPages),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.Tag),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.StackTraceInitVar),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.MemStats),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.GlobalLockOwner),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.ContextExtendLock),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.AllocatedBase),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.UncommittedBase),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.ReservedLimit),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.ReservedRegionEnd),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.CallbacksEncoded),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.SegContexts),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.VsContext),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_SEGMENT_HEAP.LfhContext),
                    new ulong[]
                    {
                        832UL
                    }
                }
            };
            Register<_SEGMENT_HEAP>((mem, ptr) => new _SEGMENT_HEAP(mem, ptr), offsets);
        }
    }
}