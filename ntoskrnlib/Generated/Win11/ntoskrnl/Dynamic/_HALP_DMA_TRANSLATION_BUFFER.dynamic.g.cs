using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_TRANSLATION_BUFFER")]
    public sealed class _HALP_DMA_TRANSLATION_BUFFER : DynamicStructure
    {
        public IntPtr Next { get; }
        public uint EntryCount { get; }
        public IntPtr Entries { get; }

        public _HALP_DMA_TRANSLATION_BUFFER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_DMA_TRANSLATION_BUFFER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_DMA_TRANSLATION_BUFFER.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_BUFFER.EntryCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_BUFFER.Entries),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HALP_DMA_TRANSLATION_BUFFER>((mem, ptr) => new _HALP_DMA_TRANSLATION_BUFFER(mem, ptr), offsets);
        }
    }
}