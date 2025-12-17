using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KSTATIC_AFFINITY_BLOCK")]
    public sealed class _KSTATIC_AFFINITY_BLOCK : DynamicStructure
    {
        public _KAFFINITY_EX KeFlushTbAffinity { get; }
        public _KAFFINITY_EX KeFlushWbAffinity { get; }
        public _KAFFINITY_EX KeSlistRollbackAffinity { get; }
        public _KAFFINITY_EX KeSyncContextAffinity { get; }
        public _KAFFINITY_EX KeRcuAffinity { get; }
        public _KAFFINITY_EX KeFlushTbDeepIdleAffinity { get; }
        public _KAFFINITY_EX KeIpiSendAffinity { get; }
        public _KAFFINITY_EX KeIpiSendIpiSet { get; }
        public ulong[] Padding { get; }

        public _KSTATIC_AFFINITY_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSTATIC_AFFINITY_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.KeFlushTbAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.KeFlushWbAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.KeSlistRollbackAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.KeSyncContextAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.KeRcuAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.KeFlushTbDeepIdleAffinity),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.KeIpiSendAffinity),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.KeIpiSendIpiSet),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_KSTATIC_AFFINITY_BLOCK.Padding),
                    new ulong[]
                    {
                        1056UL
                    }
                }
            };
            Register<_KSTATIC_AFFINITY_BLOCK>((mem, ptr) => new _KSTATIC_AFFINITY_BLOCK(mem, ptr), offsets);
        }
    }
}