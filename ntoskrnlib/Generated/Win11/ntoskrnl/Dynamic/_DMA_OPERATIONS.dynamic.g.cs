using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_OPERATIONS")]
    public sealed class _DMA_OPERATIONS : DynamicStructure
    {
        public uint Size { get; }
        public IntPtr PutDmaAdapter { get; }
        public IntPtr AllocateCommonBuffer { get; }
        public IntPtr FreeCommonBuffer { get; }
        public IntPtr AllocateAdapterChannel { get; }
        public IntPtr FlushAdapterBuffers { get; }
        public IntPtr FreeAdapterChannel { get; }
        public IntPtr FreeMapRegisters { get; }
        public IntPtr MapTransfer { get; }
        public IntPtr GetDmaAlignment { get; }
        public IntPtr ReadDmaCounter { get; }
        public IntPtr GetScatterGatherList { get; }
        public IntPtr PutScatterGatherList { get; }
        public IntPtr CalculateScatterGatherList { get; }
        public IntPtr BuildScatterGatherList { get; }
        public IntPtr BuildMdlFromScatterGatherList { get; }
        public IntPtr GetDmaAdapterInfo { get; }
        public IntPtr GetDmaTransferInfo { get; }
        public IntPtr InitializeDmaTransferContext { get; }
        public IntPtr AllocateCommonBufferEx { get; }
        public IntPtr AllocateAdapterChannelEx { get; }
        public IntPtr ConfigureAdapterChannel { get; }
        public IntPtr CancelAdapterChannel { get; }
        public IntPtr MapTransferEx { get; }
        public IntPtr GetScatterGatherListEx { get; }
        public IntPtr BuildScatterGatherListEx { get; }
        public IntPtr FlushAdapterBuffersEx { get; }
        public IntPtr FreeAdapterObject { get; }
        public IntPtr CancelMappedTransfer { get; }
        public IntPtr AllocateDomainCommonBuffer { get; }
        public IntPtr FlushDmaBuffer { get; }
        public IntPtr JoinDmaDomain { get; }
        public IntPtr LeaveDmaDomain { get; }
        public IntPtr GetDmaDomain { get; }
        public IntPtr AllocateCommonBufferWithBounds { get; }
        public IntPtr AllocateCommonBufferVector { get; }
        public IntPtr GetCommonBufferFromVectorByIndex { get; }
        public IntPtr FreeCommonBufferFromVector { get; }
        public IntPtr FreeCommonBufferVector { get; }
        public IntPtr CreateCommonBufferFromMdl { get; }

        public _DMA_OPERATIONS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_OPERATIONS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_OPERATIONS.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.PutDmaAdapter),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.AllocateCommonBuffer),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FreeCommonBuffer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.AllocateAdapterChannel),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FlushAdapterBuffers),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FreeAdapterChannel),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FreeMapRegisters),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.MapTransfer),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.GetDmaAlignment),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.ReadDmaCounter),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.GetScatterGatherList),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.PutScatterGatherList),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.CalculateScatterGatherList),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.BuildScatterGatherList),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.BuildMdlFromScatterGatherList),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.GetDmaAdapterInfo),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.GetDmaTransferInfo),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.InitializeDmaTransferContext),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.AllocateCommonBufferEx),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.AllocateAdapterChannelEx),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.ConfigureAdapterChannel),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.CancelAdapterChannel),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.MapTransferEx),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.GetScatterGatherListEx),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.BuildScatterGatherListEx),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FlushAdapterBuffersEx),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FreeAdapterObject),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.CancelMappedTransfer),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.AllocateDomainCommonBuffer),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FlushDmaBuffer),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.JoinDmaDomain),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.LeaveDmaDomain),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.GetDmaDomain),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.AllocateCommonBufferWithBounds),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.AllocateCommonBufferVector),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.GetCommonBufferFromVectorByIndex),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FreeCommonBufferFromVector),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.FreeCommonBufferVector),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_DMA_OPERATIONS.CreateCommonBufferFromMdl),
                    new ulong[]
                    {
                        312UL
                    }
                }
            };
            Register<_DMA_OPERATIONS>((mem, ptr) => new _DMA_OPERATIONS(mem, ptr), offsets);
        }
    }
}