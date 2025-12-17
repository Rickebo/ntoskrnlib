using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_CONTROLLER")]
    public sealed class _HALP_DMA_CONTROLLER : DynamicStructure
    {
        public _LIST_ENTRY Controllers { get; }
        public _LIST_ENTRY AdapterList { get; }
        public uint ControllerId { get; }
        public uint MinimumRequestLine { get; }
        public uint MaximumRequestLine { get; }
        public uint ChannelCount { get; }
        public uint ScatterGatherLimit { get; }
        public IntPtr Channels { get; }
        public IntPtr ExtensionData { get; }
        public byte CacheCoherent { get; }
        public uint DmaAddressWidth { get; }
        public _DMA_FUNCTION_TABLE Operations { get; }
        public uint SupportedPortWidths { get; }
        public uint MinimumTransferUnit { get; }
        public ulong Lock { get; }
        public byte Irql { get; }
        public byte GeneratesInterrupt { get; }
        public int Gsi { get; }
        public uint InterruptPolarity { get; }
        public uint InterruptMode { get; }
        public _UNICODE_STRING ResourceId { get; }
        public IntPtr PowerHandle { get; }
        public byte PowerActive { get; }

        public _HALP_DMA_CONTROLLER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_DMA_CONTROLLER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_DMA_CONTROLLER.Controllers),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.AdapterList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.ControllerId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.MinimumRequestLine),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.MaximumRequestLine),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.ChannelCount),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.ScatterGatherLimit),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.Channels),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.ExtensionData),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.CacheCoherent),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.DmaAddressWidth),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.Operations),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.SupportedPortWidths),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.MinimumTransferUnit),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.Lock),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.Irql),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.GeneratesInterrupt),
                    new ulong[]
                    {
                        177UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.Gsi),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.InterruptPolarity),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.InterruptMode),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.ResourceId),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.PowerHandle),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HALP_DMA_CONTROLLER.PowerActive),
                    new ulong[]
                    {
                        216UL
                    }
                }
            };
            Register<_HALP_DMA_CONTROLLER>((mem, ptr) => new _HALP_DMA_CONTROLLER(mem, ptr), offsets);
        }
    }
}