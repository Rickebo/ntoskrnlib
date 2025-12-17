using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU")]
    public sealed class _EXT_IOMMU : DynamicStructure
    {
        public IntPtr Context { get; }
        public uint Type { get; }
        public _EXT_IOMMU_CAPABILITIES Capabilities { get; }
        public uint MaxOutputAddressWidth { get; }
        public _unnamed_tag_ Flags { get; }
        public ushort PciSegmentNumber { get; }
        public _EXT_IOMMU_FUNCTION_TABLE FunctionTable { get; }

        public _EXT_IOMMU(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU.Context),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU.Type),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU.Capabilities),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXT_IOMMU.MaxOutputAddressWidth),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EXT_IOMMU.Flags),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_EXT_IOMMU.PciSegmentNumber),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(_EXT_IOMMU.FunctionTable),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_EXT_IOMMU>((mem, ptr) => new _EXT_IOMMU(mem, ptr), offsets);
        }
    }
}