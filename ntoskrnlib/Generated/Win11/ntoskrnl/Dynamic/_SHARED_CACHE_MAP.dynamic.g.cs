using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SHARED_CACHE_MAP")]
    public sealed class _SHARED_CACHE_MAP : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public short NodeByteSize { get; }
        public uint OpenCount { get; }
        public _LARGE_INTEGER FileSize { get; }
        public _LIST_ENTRY BcbList { get; }
        public _LARGE_INTEGER SectionSize { get; }
        public _LARGE_INTEGER ValidDataLength { get; }
        public _LARGE_INTEGER ValidDataGoal { get; }
        public byte[] InitialVacbs { get; }
        public IntPtr Vacbs { get; }
        public _EX_FAST_REF FileObjectFastRef { get; }
        public _EX_PUSH_LOCK VacbLock { get; }
        public uint DirtyPages { get; }
        public _LIST_ENTRY LoggedStreamLinks { get; }
        public _LIST_ENTRY SharedCacheMapLinks { get; }
        public uint Flags { get; }
        public uint Flags2 { get; }
        public int Status { get; }
        public IntPtr Mbcb { get; }
        public IntPtr Section { get; }
        public IntPtr CreateEvent { get; }
        public IntPtr WaitOnActiveCount { get; }
        public uint PagesToWrite { get; }
        public long BeyondLastFlush { get; }
        public IntPtr Callbacks { get; }
        public IntPtr CallbacksEx { get; }
        public IntPtr LazyWriteContext { get; }
        public _LIST_ENTRY PrivateList { get; }
        public _LOGGED_STREAM_CALLBACK_V1 V1 { get; }
        public _LOGGED_STREAM_CALLBACK_V2 V2 { get; }
        public _LARGE_INTEGER LargestLSN { get; }
        public uint DirtyPageThreshold { get; }
        public uint LazyWritePassCount { get; }
        public IntPtr UninitializeEvent { get; }
        public _FAST_MUTEX BcbLock { get; }
        public _LARGE_INTEGER LastUnmapBehindOffset { get; }
        public _KEVENT Event { get; }
        public _LARGE_INTEGER HighWaterMappingOffset { get; }
        public _PRIVATE_CACHE_MAP PrivateCacheMap { get; }
        public IntPtr WriteBehindWorkQueueEntry { get; }
        public IntPtr VolumeCacheMap { get; }
        public uint ProcImagePathHash { get; }
        public uint WritesInProgress { get; }
        public uint AsyncReadRequestCount { get; }
        public IntPtr Partition { get; }
        public uint InternalRefCount { get; }
        public uint NumMappedVacb { get; }
        public uint NumActiveVacb { get; }
        public uint IdealNodeForWriteBehind { get; }
        public uint IdealNodeNumber { get; }
        public _LIST_ENTRY VolSharedCacheMapLinks { get; }
        public _LIST_ENTRY VolLoggedStreamLinks { get; }
        public IntPtr PrivateVolumeCacheMap { get; }
        public uint SectionSizeIncrement { get; }

        public _SHARED_CACHE_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SHARED_CACHE_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SHARED_CACHE_MAP.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.NodeByteSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.OpenCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.FileSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.BcbList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.SectionSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.ValidDataLength),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.ValidDataGoal),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.InitialVacbs),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Vacbs),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.FileObjectFastRef),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.VacbLock),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.DirtyPages),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.LoggedStreamLinks),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.SharedCacheMapLinks),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Flags),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Flags2),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Status),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Mbcb),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Section),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.CreateEvent),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.WaitOnActiveCount),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.PagesToWrite),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.BeyondLastFlush),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Callbacks),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.CallbacksEx),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.LazyWriteContext),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.PrivateList),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.V1),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.V2),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.LargestLSN),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.DirtyPageThreshold),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.LazyWritePassCount),
                    new ulong[]
                    {
                        276UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.UninitializeEvent),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.BcbLock),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.LastUnmapBehindOffset),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Event),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.HighWaterMappingOffset),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.PrivateCacheMap),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.WriteBehindWorkQueueEntry),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.VolumeCacheMap),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.ProcImagePathHash),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.WritesInProgress),
                    new ulong[]
                    {
                        524UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.AsyncReadRequestCount),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.Partition),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.InternalRefCount),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.NumMappedVacb),
                    new ulong[]
                    {
                        548UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.NumActiveVacb),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.IdealNodeForWriteBehind),
                    new ulong[]
                    {
                        556UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.IdealNodeNumber),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.VolSharedCacheMapLinks),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.VolLoggedStreamLinks),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.PrivateVolumeCacheMap),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_SHARED_CACHE_MAP.SectionSizeIncrement),
                    new ulong[]
                    {
                        608UL
                    }
                }
            };
            Register<_SHARED_CACHE_MAP>((mem, ptr) => new _SHARED_CACHE_MAP(mem, ptr), offsets);
        }
    }
}