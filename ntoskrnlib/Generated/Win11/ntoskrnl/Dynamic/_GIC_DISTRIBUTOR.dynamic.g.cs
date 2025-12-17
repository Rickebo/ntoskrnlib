using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GIC_DISTRIBUTOR")]
    public sealed class _GIC_DISTRIBUTOR : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Reserved1 { get; }
        public uint Identifier { get; }
        public ulong ControllerPhysicalAddress { get; }
        public uint GsivBase { get; }
        public byte Version { get; }
        public byte[] Reserved { get; }

        public _GIC_DISTRIBUTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GIC_DISTRIBUTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GIC_DISTRIBUTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GIC_DISTRIBUTOR.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_GIC_DISTRIBUTOR.Reserved1),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_GIC_DISTRIBUTOR.Identifier),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_GIC_DISTRIBUTOR.ControllerPhysicalAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_GIC_DISTRIBUTOR.GsivBase),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_GIC_DISTRIBUTOR.Version),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_GIC_DISTRIBUTOR.Reserved),
                    new ulong[]
                    {
                        21UL
                    }
                }
            };
            Register<_GIC_DISTRIBUTOR>((mem, ptr) => new _GIC_DISTRIBUTOR(mem, ptr), offsets);
        }
    }
}