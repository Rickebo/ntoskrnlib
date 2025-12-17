using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MIPFNFLINK")]
    public sealed class _MIPFNFLINK : DynamicStructure
    {
        public IntPtr NextSlistPfn { get; }
        public IntPtr Next { get; }
        public ulong Flink { get; }
        public ulong NodeFlinkLow { get; }
        public ulong EntireField { get; }
        public _MI_ACTIVE_PFN Active { get; }

        public _MIPFNFLINK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MIPFNFLINK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MIPFNFLINK.NextSlistPfn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNFLINK.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNFLINK.Flink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNFLINK.NodeFlinkLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNFLINK.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNFLINK.Active),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MIPFNFLINK>((mem, ptr) => new _MIPFNFLINK(mem, ptr), offsets);
        }
    }
}