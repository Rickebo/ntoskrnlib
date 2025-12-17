using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_ADAPTER_INFO_CRASHDUMP")]
    public sealed class _DMA_ADAPTER_INFO_CRASHDUMP : DynamicStructure
    {
        public _DEVICE_DESCRIPTION DeviceDescription { get; }
        public ulong DeviceIdSize { get; }
        public IntPtr DeviceId { get; }

        public _DMA_ADAPTER_INFO_CRASHDUMP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_ADAPTER_INFO_CRASHDUMP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_ADAPTER_INFO_CRASHDUMP.DeviceDescription),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO_CRASHDUMP.DeviceIdSize),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DMA_ADAPTER_INFO_CRASHDUMP.DeviceId),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_DMA_ADAPTER_INFO_CRASHDUMP>((mem, ptr) => new _DMA_ADAPTER_INFO_CRASHDUMP(mem, ptr), offsets);
        }
    }
}