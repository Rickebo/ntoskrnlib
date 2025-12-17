using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_HV_SYSTEM_PASID_CAPABILITIES")]
    public sealed class _HAL_HV_SYSTEM_PASID_CAPABILITIES : DynamicStructure
    {
        public uint SvmSupported { get; }
        public uint GpaAlwaysValid { get; }
        public uint PasidSupported { get; }
        public uint MaxPasidSpacePasidCount { get; }
        public uint MaxPrqSize { get; }
        public uint SvmIommuCount { get; }
        public uint MinIommuPasidCount { get; }

        public _HAL_HV_SYSTEM_PASID_CAPABILITIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_HV_SYSTEM_PASID_CAPABILITIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_HV_SYSTEM_PASID_CAPABILITIES.SvmSupported),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_SYSTEM_PASID_CAPABILITIES.GpaAlwaysValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_SYSTEM_PASID_CAPABILITIES.PasidSupported),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_HV_SYSTEM_PASID_CAPABILITIES.MaxPasidSpacePasidCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HAL_HV_SYSTEM_PASID_CAPABILITIES.MaxPrqSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_HV_SYSTEM_PASID_CAPABILITIES.SvmIommuCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HAL_HV_SYSTEM_PASID_CAPABILITIES.MinIommuPasidCount),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HAL_HV_SYSTEM_PASID_CAPABILITIES>((mem, ptr) => new _HAL_HV_SYSTEM_PASID_CAPABILITIES(mem, ptr), offsets);
        }
    }
}