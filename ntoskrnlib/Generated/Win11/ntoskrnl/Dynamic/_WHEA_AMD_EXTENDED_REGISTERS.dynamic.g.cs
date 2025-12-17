using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_AMD_EXTENDED_REGISTERS")]
    public sealed class _WHEA_AMD_EXTENDED_REGISTERS : DynamicStructure
    {
        public ulong IPID { get; }
        public ulong SYND { get; }
        public ulong CONFIG { get; }
        public ulong DESTAT { get; }
        public ulong DEADDR { get; }
        public ulong MISC1 { get; }
        public ulong MISC2 { get; }
        public ulong MISC3 { get; }
        public ulong MISC4 { get; }
        public ulong RasCap { get; }
        public ulong[] Reserved { get; }

        public _WHEA_AMD_EXTENDED_REGISTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_AMD_EXTENDED_REGISTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.IPID),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.SYND),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.CONFIG),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.DESTAT),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.DEADDR),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.MISC1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.MISC2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.MISC3),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.MISC4),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.RasCap),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_WHEA_AMD_EXTENDED_REGISTERS.Reserved),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_WHEA_AMD_EXTENDED_REGISTERS>((mem, ptr) => new _WHEA_AMD_EXTENDED_REGISTERS(mem, ptr), offsets);
        }
    }
}