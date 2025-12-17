using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_PORT_ATTRIBUTES")]
    public sealed class _ALPC_PORT_ATTRIBUTES : DynamicStructure
    {
        public uint Flags { get; }
        public _SECURITY_QUALITY_OF_SERVICE SecurityQos { get; }
        public ulong MaxMessageLength { get; }
        public ulong MemoryBandwidth { get; }
        public ulong MaxPoolUsage { get; }
        public ulong MaxSectionSize { get; }
        public ulong MaxViewSize { get; }
        public ulong MaxTotalSectionSize { get; }
        public uint DupObjectTypes { get; }
        public uint Reserved { get; }

        public _ALPC_PORT_ATTRIBUTES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_PORT_ATTRIBUTES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.SecurityQos),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.MaxMessageLength),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.MemoryBandwidth),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.MaxPoolUsage),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.MaxSectionSize),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.MaxViewSize),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.MaxTotalSectionSize),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.DupObjectTypes),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ALPC_PORT_ATTRIBUTES.Reserved),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_ALPC_PORT_ATTRIBUTES>((mem, ptr) => new _ALPC_PORT_ATTRIBUTES(mem, ptr), offsets);
        }
    }
}