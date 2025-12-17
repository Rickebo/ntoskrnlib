using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GIC_REDISTRIBUTOR")]
    public sealed class _GIC_REDISTRIBUTOR : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Reserved { get; }
        public ulong DiscoveryRangeBaseAddress { get; }
        public uint DiscoveryRangeLength { get; }

        public _GIC_REDISTRIBUTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GIC_REDISTRIBUTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GIC_REDISTRIBUTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GIC_REDISTRIBUTOR.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_GIC_REDISTRIBUTOR.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_GIC_REDISTRIBUTOR.DiscoveryRangeBaseAddress),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_GIC_REDISTRIBUTOR.DiscoveryRangeLength),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_GIC_REDISTRIBUTOR>((mem, ptr) => new _GIC_REDISTRIBUTOR(mem, ptr), offsets);
        }
    }
}