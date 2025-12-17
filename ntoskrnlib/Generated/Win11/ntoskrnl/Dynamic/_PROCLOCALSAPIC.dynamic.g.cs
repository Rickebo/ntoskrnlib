using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCLOCALSAPIC")]
    public sealed class _PROCLOCALSAPIC : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public byte ACPIProcessorID { get; }
        public byte APICID { get; }
        public byte APICEID { get; }
        public byte[] Reserved { get; }
        public uint Flags { get; }
        public uint ACPIProcessorUIDInteger { get; }
        public sbyte[] ACPIProcessorUIDString { get; }

        public _PROCLOCALSAPIC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCLOCALSAPIC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCLOCALSAPIC.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCLOCALSAPIC.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PROCLOCALSAPIC.ACPIProcessorID),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROCLOCALSAPIC.APICID),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PROCLOCALSAPIC.APICEID),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROCLOCALSAPIC.Reserved),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_PROCLOCALSAPIC.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROCLOCALSAPIC.ACPIProcessorUIDInteger),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PROCLOCALSAPIC.ACPIProcessorUIDString),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PROCLOCALSAPIC>((mem, ptr) => new _PROCLOCALSAPIC(mem, ptr), offsets);
        }
    }
}