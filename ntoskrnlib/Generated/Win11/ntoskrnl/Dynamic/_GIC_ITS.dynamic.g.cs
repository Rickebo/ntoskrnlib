using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GIC_ITS")]
    public sealed class _GIC_ITS : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Reserved1 { get; }
        public uint Identifier { get; }
        public ulong PhysicalAddress { get; }
        public uint Reserved2 { get; }

        public _GIC_ITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GIC_ITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GIC_ITS.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GIC_ITS.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_GIC_ITS.Reserved1),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_GIC_ITS.Identifier),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_GIC_ITS.PhysicalAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_GIC_ITS.Reserved2),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_GIC_ITS>((mem, ptr) => new _GIC_ITS(mem, ptr), offsets);
        }
    }
}