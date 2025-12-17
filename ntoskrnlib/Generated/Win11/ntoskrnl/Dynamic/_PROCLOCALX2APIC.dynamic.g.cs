using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCLOCALX2APIC")]
    public sealed class _PROCLOCALX2APIC : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Reserved { get; }
        public uint APICID { get; }
        public uint Flags { get; }
        public uint ACPIProcessorID { get; }

        public _PROCLOCALX2APIC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCLOCALX2APIC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCLOCALX2APIC.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCLOCALX2APIC.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PROCLOCALX2APIC.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROCLOCALX2APIC.APICID),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROCLOCALX2APIC.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROCLOCALX2APIC.ACPIProcessorID),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_PROCLOCALX2APIC>((mem, ptr) => new _PROCLOCALX2APIC(mem, ptr), offsets);
        }
    }
}