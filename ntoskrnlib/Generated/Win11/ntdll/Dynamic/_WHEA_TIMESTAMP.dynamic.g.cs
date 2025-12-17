using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_TIMESTAMP")]
    public sealed class _WHEA_TIMESTAMP : DynamicStructure
    {
        public ulong Seconds { get; }
        public ulong Minutes { get; }
        public ulong Hours { get; }
        public ulong Precise { get; }
        public ulong Reserved { get; }
        public ulong Day { get; }
        public ulong Month { get; }
        public ulong Year { get; }
        public ulong Century { get; }
        public _LARGE_INTEGER AsLARGE_INTEGER { get; }

        public _WHEA_TIMESTAMP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_TIMESTAMP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_TIMESTAMP.Seconds),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.Minutes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.Hours),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.Precise),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.Day),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.Month),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.Year),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.Century),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_TIMESTAMP.AsLARGE_INTEGER),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_TIMESTAMP>((mem, ptr) => new _WHEA_TIMESTAMP(mem, ptr), offsets);
        }
    }
}