using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_CHANNEL")]
    public sealed class _HALP_DMA_CHANNEL : DynamicStructure
    {
        public uint ChannelNumber { get; }
        public byte Initialized { get; }
        public byte Busy { get; }
        public byte Complete { get; }
        public IntPtr CurrentCompletionRoutine { get; }
        public IntPtr CurrentCompletionContext { get; }
        public IntPtr CurrentChildAdapter { get; }
        public uint CurrentInterruptType { get; }
        public _KDPC Dpc { get; }
        public byte GeneratesInterrupt { get; }
        public int Gsi { get; }
        public uint InterruptPolarity { get; }
        public uint InterruptMode { get; }
        public uint CommonBufferLength { get; }
        public IntPtr CommonBufferVirtualAddress { get; }
        public _LARGE_INTEGER CommonBufferLogicalAddress { get; }
        public _LIST_ENTRY AdapterQueue { get; }

        public _HALP_DMA_CHANNEL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_DMA_CHANNEL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_DMA_CHANNEL.ChannelNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.Initialized),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.Busy),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.Complete),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.CurrentCompletionRoutine),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.CurrentCompletionContext),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.CurrentChildAdapter),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.CurrentInterruptType),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.Dpc),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.GeneratesInterrupt),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.Gsi),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.InterruptPolarity),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.InterruptMode),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.CommonBufferLength),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.CommonBufferVirtualAddress),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.CommonBufferLogicalAddress),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_HALP_DMA_CHANNEL.AdapterQueue),
                    new ulong[]
                    {
                        144UL
                    }
                }
            };
            Register<_HALP_DMA_CHANNEL>((mem, ptr) => new _HALP_DMA_CHANNEL(mem, ptr), offsets);
        }
    }
}