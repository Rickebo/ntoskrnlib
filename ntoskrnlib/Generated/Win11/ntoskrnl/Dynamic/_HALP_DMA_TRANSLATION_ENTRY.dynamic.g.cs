using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_TRANSLATION_ENTRY")]
    public sealed class _HALP_DMA_TRANSLATION_ENTRY : DynamicStructure
    {
        public ulong PhysicalAddress { get; }
        public IntPtr Next { get; }
        public uint MappedLength { get; }
        public _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT RemappingAddress { get; }
        public _unnamed_tag_ u { get; }
        public IntPtr NextMapping { get; }
        public byte LogicalBounceBufferPremapped { get; }

        public _HALP_DMA_TRANSLATION_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_DMA_TRANSLATION_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_DMA_TRANSLATION_ENTRY.PhysicalAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_ENTRY.Next),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_ENTRY.MappedLength),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_ENTRY.RemappingAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_ENTRY.u),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_ENTRY.NextMapping),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HALP_DMA_TRANSLATION_ENTRY.LogicalBounceBufferPremapped),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_HALP_DMA_TRANSLATION_ENTRY>((mem, ptr) => new _HALP_DMA_TRANSLATION_ENTRY(mem, ptr), offsets);
        }
    }
}