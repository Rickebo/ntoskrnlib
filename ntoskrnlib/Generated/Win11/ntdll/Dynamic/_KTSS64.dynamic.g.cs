using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KTSS64")]
    public sealed class _KTSS64 : DynamicStructure
    {
        public uint Reserved0 { get; }
        public ulong Rsp0 { get; }
        public ulong Rsp1 { get; }
        public ulong Rsp2 { get; }
        public ulong[] Ist { get; }
        public ulong Reserved1 { get; }
        public ushort Reserved2 { get; }
        public ushort IoMapBase { get; }

        public _KTSS64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTSS64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTSS64.Reserved0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTSS64.Rsp0),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KTSS64.Rsp1),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KTSS64.Rsp2),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_KTSS64.Ist),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_KTSS64.Reserved1),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_KTSS64.Reserved2),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_KTSS64.IoMapBase),
                    new ulong[]
                    {
                        102UL
                    }
                }
            };
            Register<_KTSS64>((mem, ptr) => new _KTSS64(mem, ptr), offsets);
        }
    }
}