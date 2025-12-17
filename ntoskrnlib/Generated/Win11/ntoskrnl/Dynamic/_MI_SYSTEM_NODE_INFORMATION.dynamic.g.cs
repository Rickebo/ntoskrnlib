using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_NODE_INFORMATION")]
    public sealed class _MI_SYSTEM_NODE_INFORMATION : DynamicStructure
    {
        public _MI_SYSTEM_NODE_AFFINITY_INFORMATION Affinities { get; }
        public _unnamed_tag_ Flags { get; }
        public _MI_NODE_NUMBER_ZERO_BASED ProcessorNode { get; }
        public _GROUP_AFFINITY ForwardProgressGroupAffinity { get; }
        public int LargePageListOpLock { get; }
        public byte[] WriteCalibration { get; }
        public byte[] MaximumBandwidth { get; }
        public int IoPfnLock { get; }
        public byte[] DeferredPfnsToFree { get; }
        public _MI_DEFERRED_PFNS_TO_FREE DeferredPfnsReady { get; }
        public int DeferredPfnsToFreeLock { get; }

        public _MI_SYSTEM_NODE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_NODE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.Affinities),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.Flags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.ProcessorNode),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.ForwardProgressGroupAffinity),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.LargePageListOpLock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.WriteCalibration),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.MaximumBandwidth),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.IoPfnLock),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.DeferredPfnsToFree),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.DeferredPfnsReady),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_NODE_INFORMATION.DeferredPfnsToFreeLock),
                    new ulong[]
                    {
                        808UL
                    }
                }
            };
            Register<_MI_SYSTEM_NODE_INFORMATION>((mem, ptr) => new _MI_SYSTEM_NODE_INFORMATION(mem, ptr), offsets);
        }
    }
}