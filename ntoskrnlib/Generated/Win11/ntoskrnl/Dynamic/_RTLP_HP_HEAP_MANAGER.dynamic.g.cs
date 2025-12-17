using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTLP_HP_HEAP_MANAGER")]
    public sealed class _RTLP_HP_HEAP_MANAGER : DynamicStructure
    {
        public IntPtr Globals { get; }
        public _RTLP_HP_ALLOC_TRACKER AllocTracker { get; }
        public _HEAP_VAMGR_CTX VaMgr { get; }
        public byte[] MetadataHeaps { get; }
        public _RTL_HP_SUB_ALLOCATOR_CONFIGS SubAllocConfigs { get; }

        public _RTLP_HP_HEAP_MANAGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_HP_HEAP_MANAGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_HP_HEAP_MANAGER.Globals),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_MANAGER.AllocTracker),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_MANAGER.VaMgr),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_MANAGER.MetadataHeaps),
                    new ulong[]
                    {
                        14488UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_MANAGER.SubAllocConfigs),
                    new ulong[]
                    {
                        14552UL
                    }
                }
            };
            Register<_RTLP_HP_HEAP_MANAGER>((mem, ptr) => new _RTLP_HP_HEAP_MANAGER(mem, ptr), offsets);
        }
    }
}