using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOAPIC")]
    public sealed class _IOAPIC : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public byte IOAPICID { get; }
        public byte Reserved { get; }
        public uint IOAPICAddress { get; }
        public uint SystemVectorBase { get; }

        public _IOAPIC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOAPIC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOAPIC.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOAPIC.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_IOAPIC.IOAPICID),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IOAPIC.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_IOAPIC.IOAPICAddress),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IOAPIC.SystemVectorBase),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IOAPIC>((mem, ptr) => new _IOAPIC(mem, ptr), offsets);
        }
    }
}