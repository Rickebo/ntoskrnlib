using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_RESERVATION_CLUSTER_INFO")]
    public sealed class _MI_RESERVATION_CLUSTER_INFO : DynamicStructure
    {
        public uint ClusterSize { get; }
        public uint SequenceNumber { get; }
        public int EntireInfo { get; }

        public _MI_RESERVATION_CLUSTER_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_RESERVATION_CLUSTER_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_RESERVATION_CLUSTER_INFO.ClusterSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_RESERVATION_CLUSTER_INFO.SequenceNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_RESERVATION_CLUSTER_INFO.EntireInfo),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_RESERVATION_CLUSTER_INFO>((mem, ptr) => new _MI_RESERVATION_CLUSTER_INFO(mem, ptr), offsets);
        }
    }
}