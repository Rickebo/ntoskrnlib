using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION")]
    public sealed class _DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION : DynamicStructure
    {
        public uint ConfigType { get; }
        public _unnamed_tag_ LogicalAddressLimits { get; }
        public _unnamed_tag_ SubSection { get; }
        public uint HardwareAccessType { get; }
        public ulong[] Reserved { get; }

        public _DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION.ConfigType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION.LogicalAddressLimits),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION.SubSection),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION.HardwareAccessType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION.Reserved),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION>((mem, ptr) => new _DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION(mem, ptr), offsets);
        }
    }
}