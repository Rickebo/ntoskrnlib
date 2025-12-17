using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_TRANSFER_CONTEXT_V1")]
    public sealed class _DMA_TRANSFER_CONTEXT_V1 : DynamicStructure
    {
        public int DmaState { get; }
        public uint TransferState { get; }
        public _WAIT_CONTEXT_BLOCK Wcb { get; }
        public IntPtr HalWcb { get; }

        public _DMA_TRANSFER_CONTEXT_V1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_TRANSFER_CONTEXT_V1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_TRANSFER_CONTEXT_V1.DmaState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_CONTEXT_V1.TransferState),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_CONTEXT_V1.Wcb),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_TRANSFER_CONTEXT_V1.HalWcb),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_DMA_TRANSFER_CONTEXT_V1>((mem, ptr) => new _DMA_TRANSFER_CONTEXT_V1(mem, ptr), offsets);
        }
    }
}