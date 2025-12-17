using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_FLUSH_CONTEXT")]
    public sealed class _EXT_IOMMU_FLUSH_CONTEXT : DynamicStructure
    {
        public _unnamed_tag_ Intel { get; }
        public _unnamed_tag_ Amd { get; }

        public _EXT_IOMMU_FLUSH_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_FLUSH_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_FLUSH_CONTEXT.Intel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FLUSH_CONTEXT.Amd),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EXT_IOMMU_FLUSH_CONTEXT>((mem, ptr) => new _EXT_IOMMU_FLUSH_CONTEXT(mem, ptr), offsets);
        }
    }
}