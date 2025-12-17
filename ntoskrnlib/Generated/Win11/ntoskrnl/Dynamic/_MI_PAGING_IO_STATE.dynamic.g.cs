using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGING_IO_STATE")]
    public sealed class _MI_PAGING_IO_STATE : DynamicStructure
    {
        public _RTL_AVL_TREE PageFileHead { get; }
        public int PageFileHeadSpinLock { get; }
        public _MI_PAGEFILE_METADATA_LAYOUT PageFileMetadata { get; }
        public int PrefetchSeekThreshold { get; }
        public uint InPageSinglePages { get; }
        public byte[] InPageSupportSListHead { get; }
        public byte[] ReservedInPageSupportSListHead { get; }
        public byte[] InPageSupportSListMinimum { get; }
        public byte[] FirstReservedInPageBlock { get; }
        public byte[] LastReservedInPageBlock { get; }
        public IntPtr ReservedPtes { get; }
        public int ReservedPtesLock { get; }
        public uint ReservedPtesBitBuffer { get; }
        public int DelayPageFaults { get; }
        public byte MdlsAdjusted { get; }
        public int NumberOfFailedStoreReads { get; }

        public _MI_PAGING_IO_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGING_IO_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGING_IO_STATE.PageFileHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.PageFileHeadSpinLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.PageFileMetadata),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.PrefetchSeekThreshold),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.InPageSinglePages),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.InPageSupportSListHead),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.ReservedInPageSupportSListHead),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.InPageSupportSListMinimum),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.FirstReservedInPageBlock),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.LastReservedInPageBlock),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.ReservedPtes),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.ReservedPtesLock),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.ReservedPtesBitBuffer),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.DelayPageFaults),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.MdlsAdjusted),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_MI_PAGING_IO_STATE.NumberOfFailedStoreReads),
                    new ulong[]
                    {
                        160UL
                    }
                }
            };
            Register<_MI_PAGING_IO_STATE>((mem, ptr) => new _MI_PAGING_IO_STATE(mem, ptr), offsets);
        }
    }
}