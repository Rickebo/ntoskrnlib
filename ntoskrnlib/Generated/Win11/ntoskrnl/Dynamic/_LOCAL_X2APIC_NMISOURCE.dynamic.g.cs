using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOCAL_X2APIC_NMISOURCE")]
    public sealed class _LOCAL_X2APIC_NMISOURCE : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Flags { get; }
        public uint ProcessorID { get; }
        public byte LINTIN { get; }
        public byte[] Reserved { get; }

        public _LOCAL_X2APIC_NMISOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOCAL_X2APIC_NMISOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOCAL_X2APIC_NMISOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOCAL_X2APIC_NMISOURCE.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_LOCAL_X2APIC_NMISOURCE.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_LOCAL_X2APIC_NMISOURCE.ProcessorID),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOCAL_X2APIC_NMISOURCE.LINTIN),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOCAL_X2APIC_NMISOURCE.Reserved),
                    new ulong[]
                    {
                        9UL
                    }
                }
            };
            Register<_LOCAL_X2APIC_NMISOURCE>((mem, ptr) => new _LOCAL_X2APIC_NMISOURCE(mem, ptr), offsets);
        }
    }
}