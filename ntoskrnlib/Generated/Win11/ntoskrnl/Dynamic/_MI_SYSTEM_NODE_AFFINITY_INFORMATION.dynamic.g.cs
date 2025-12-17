using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_NODE_AFFINITY_INFORMATION")]
    public sealed class _MI_SYSTEM_NODE_AFFINITY_INFORMATION : DynamicStructure
    {
        public IntPtr GroupAffinity { get; }
        public uint NumberOfDomains { get; }
        public uint GlobalDomainIndex { get; }
        public ushort GroupAffinityCount { get; }
        public ushort[] ProcessorCount { get; }
        public ushort[] UsableProcessorCount { get; }

        public _MI_SYSTEM_NODE_AFFINITY_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_NODE_AFFINITY_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_NODE_AFFINITY_INFORMATION.GroupAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_AFFINITY_INFORMATION.NumberOfDomains),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_AFFINITY_INFORMATION.GlobalDomainIndex),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_AFFINITY_INFORMATION.GroupAffinityCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_AFFINITY_INFORMATION.ProcessorCount),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_AFFINITY_INFORMATION.UsableProcessorCount),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_SYSTEM_NODE_AFFINITY_INFORMATION>((mem, ptr) => new _MI_SYSTEM_NODE_AFFINITY_INFORMATION(mem, ptr), offsets);
        }
    }
}