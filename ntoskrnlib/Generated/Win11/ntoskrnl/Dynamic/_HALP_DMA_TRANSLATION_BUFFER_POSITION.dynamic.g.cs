using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_TRANSLATION_BUFFER_POSITION")]
    public sealed class _HALP_DMA_TRANSLATION_BUFFER_POSITION : DynamicStructure
    {
        public IntPtr Buffer { get; }
        public uint Offset { get; }

        public _HALP_DMA_TRANSLATION_BUFFER_POSITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_DMA_TRANSLATION_BUFFER_POSITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_DMA_TRANSLATION_BUFFER_POSITION.Buffer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_BUFFER_POSITION.Offset),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HALP_DMA_TRANSLATION_BUFFER_POSITION>((mem, ptr) => new _HALP_DMA_TRANSLATION_BUFFER_POSITION(mem, ptr), offsets);
        }
    }
}