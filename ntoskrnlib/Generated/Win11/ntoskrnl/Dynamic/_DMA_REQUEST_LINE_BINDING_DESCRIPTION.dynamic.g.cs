using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_REQUEST_LINE_BINDING_DESCRIPTION")]
    public sealed class _DMA_REQUEST_LINE_BINDING_DESCRIPTION : DynamicStructure
    {
        public uint RequestLine { get; }
        public uint ChannelNumber { get; }

        public _DMA_REQUEST_LINE_BINDING_DESCRIPTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_REQUEST_LINE_BINDING_DESCRIPTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_REQUEST_LINE_BINDING_DESCRIPTION.RequestLine),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_REQUEST_LINE_BINDING_DESCRIPTION.ChannelNumber),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_DMA_REQUEST_LINE_BINDING_DESCRIPTION>((mem, ptr) => new _DMA_REQUEST_LINE_BINDING_DESCRIPTION(mem, ptr), offsets);
        }
    }
}