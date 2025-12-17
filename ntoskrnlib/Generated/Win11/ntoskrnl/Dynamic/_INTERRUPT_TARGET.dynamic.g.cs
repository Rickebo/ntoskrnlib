using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_TARGET")]
    public sealed class _INTERRUPT_TARGET : DynamicStructure
    {
        public uint Target { get; }
        public uint PhysicalTarget { get; }
        public uint LogicalFlatTarget { get; }
        public uint RemapIndex { get; }
        public uint ClusterId { get; }
        public uint ClusterMask { get; }
        public _unnamed_tag_ HypervisorTarget { get; }

        public _INTERRUPT_TARGET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_TARGET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_TARGET.Target),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_TARGET.PhysicalTarget),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERRUPT_TARGET.LogicalFlatTarget),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERRUPT_TARGET.RemapIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERRUPT_TARGET.ClusterId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERRUPT_TARGET.ClusterMask),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_INTERRUPT_TARGET.HypervisorTarget),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_INTERRUPT_TARGET>((mem, ptr) => new _INTERRUPT_TARGET(mem, ptr), offsets);
        }
    }
}