using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPFNLIST")]
    public sealed class _MMPFNLIST : DynamicStructure
    {
        public ulong Total { get; }
        public _MI_COLOR Color { get; }
        public uint ListName { get; }
        public ulong Flink { get; }
        public ulong Blink { get; }
        public int Lock { get; }
        public _MMPFN EmbeddedPfn { get; }

        public _MMPFNLIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPFNLIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPFNLIST.Total),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPFNLIST.Color),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMPFNLIST.ListName),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MMPFNLIST.Flink),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMPFNLIST.Blink),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMPFNLIST.Lock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMPFNLIST.EmbeddedPfn),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_MMPFNLIST>((mem, ptr) => new _MMPFNLIST(mem, ptr), offsets);
        }
    }
}