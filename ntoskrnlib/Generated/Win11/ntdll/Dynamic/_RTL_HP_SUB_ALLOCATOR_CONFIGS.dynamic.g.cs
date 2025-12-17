using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_HP_SUB_ALLOCATOR_CONFIGS")]
    public sealed class _RTL_HP_SUB_ALLOCATOR_CONFIGS : DynamicStructure
    {
        public _RTL_HP_LFH_CONFIG LfhConfigs { get; }
        public _RTL_HP_VS_CONFIG VsConfigs { get; }

        public _RTL_HP_SUB_ALLOCATOR_CONFIGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_HP_SUB_ALLOCATOR_CONFIGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_HP_SUB_ALLOCATOR_CONFIGS.LfhConfigs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_HP_SUB_ALLOCATOR_CONFIGS.VsConfigs),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_RTL_HP_SUB_ALLOCATOR_CONFIGS>((mem, ptr) => new _RTL_HP_SUB_ALLOCATOR_CONFIGS(mem, ptr), offsets);
        }
    }
}