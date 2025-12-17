using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GIC_MSIFRAME_ENTRY")]
    public sealed class _GIC_MSIFRAME_ENTRY : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Reserved1 { get; }
        public uint Identifier { get; }
        public ulong PhysicalAddress { get; }
        public uint Flags { get; }
        public ushort SpiCount { get; }
        public ushort SpiBase { get; }

        public _GIC_MSIFRAME_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GIC_MSIFRAME_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GIC_MSIFRAME_ENTRY.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GIC_MSIFRAME_ENTRY.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_GIC_MSIFRAME_ENTRY.Reserved1),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_GIC_MSIFRAME_ENTRY.Identifier),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_GIC_MSIFRAME_ENTRY.PhysicalAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_GIC_MSIFRAME_ENTRY.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_GIC_MSIFRAME_ENTRY.SpiCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_GIC_MSIFRAME_ENTRY.SpiBase),
                    new ulong[]
                    {
                        22UL
                    }
                }
            };
            Register<_GIC_MSIFRAME_ENTRY>((mem, ptr) => new _GIC_MSIFRAME_ENTRY(mem, ptr), offsets);
        }
    }
}