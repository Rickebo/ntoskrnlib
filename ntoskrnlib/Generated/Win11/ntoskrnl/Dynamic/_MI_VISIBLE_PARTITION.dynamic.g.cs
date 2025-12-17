using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_VISIBLE_PARTITION")]
    public sealed class _MI_VISIBLE_PARTITION : DynamicStructure
    {
        public ulong LowestPhysicalPage { get; }
        public ulong HighestPhysicalPage { get; }
        public ulong NumberOfPhysicalPages { get; }
        public uint NumberOfPagingFiles { get; }
        public byte SystemCacheInitialized { get; }
        public byte[] PagingFile { get; }
        public ulong AvailablePages { get; }
        public ulong ResidentAvailablePages { get; }
        public byte[] PartitionWs { get; }
        public ulong TotalCommittedPages { get; }
        public ulong TotalCommittedPagesExposed { get; }
        public _MMPFNLIST ModifiedPageListHead { get; }
        public _MMPFNLIST ModifiedNoWritePageListHead { get; }
        public ulong TotalCommitLimit { get; }
        public ulong TotalPagesForPagingFile { get; }
        public ulong VadPhysicalPages { get; }
        public ulong ProcessLockedFilePages { get; }
        public ulong SharedCommit { get; }
        public ulong MdlPagesAllocated { get; }
        public ulong ContiguousPagesAllocated { get; }
        public ulong SlabAllocatorPages { get; }
        public ulong SlabAllocatorPagesUncharged { get; }
        public ulong BootSlabPages { get; }
        public ulong SecureKernelPagesFromNonChargedSlabs { get; }
        public uint[] ChargeCommitmentFailures { get; }
        public int PageFileTraceIndex { get; }
        public byte[] PageFileTraces { get; }

        public _MI_VISIBLE_PARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_VISIBLE_PARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_VISIBLE_PARTITION.LowestPhysicalPage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.HighestPhysicalPage),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.NumberOfPhysicalPages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.NumberOfPagingFiles),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.SystemCacheInitialized),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.PagingFile),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.AvailablePages),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.ResidentAvailablePages),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.PartitionWs),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.TotalCommittedPages),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.TotalCommittedPagesExposed),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.ModifiedPageListHead),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.ModifiedNoWritePageListHead),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.TotalCommitLimit),
                    new ulong[]
                    {
                        1112UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.TotalPagesForPagingFile),
                    new ulong[]
                    {
                        1120UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.VadPhysicalPages),
                    new ulong[]
                    {
                        1128UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.ProcessLockedFilePages),
                    new ulong[]
                    {
                        1136UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.SharedCommit),
                    new ulong[]
                    {
                        1144UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.MdlPagesAllocated),
                    new ulong[]
                    {
                        1152UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.ContiguousPagesAllocated),
                    new ulong[]
                    {
                        1160UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.SlabAllocatorPages),
                    new ulong[]
                    {
                        1168UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.SlabAllocatorPagesUncharged),
                    new ulong[]
                    {
                        1176UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.BootSlabPages),
                    new ulong[]
                    {
                        1184UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.SecureKernelPagesFromNonChargedSlabs),
                    new ulong[]
                    {
                        1192UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.ChargeCommitmentFailures),
                    new ulong[]
                    {
                        1200UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.PageFileTraceIndex),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_PARTITION.PageFileTraces),
                    new ulong[]
                    {
                        1224UL
                    }
                }
            };
            Register<_MI_VISIBLE_PARTITION>((mem, ptr) => new _MI_VISIBLE_PARTITION(mem, ptr), offsets);
        }
    }
}