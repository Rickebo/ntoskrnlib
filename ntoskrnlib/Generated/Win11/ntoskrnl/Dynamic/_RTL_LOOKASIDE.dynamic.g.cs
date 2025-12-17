using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_LOOKASIDE")]
    public sealed class _RTL_LOOKASIDE : DynamicStructure
    {
        public _SLIST_HEADER ListHead { get; }
        public ushort Depth { get; }
        public ushort MaximumDepth { get; }
        public uint TotalAllocates { get; }
        public uint AllocateMisses { get; }
        public uint TotalFrees { get; }
        public uint FreeMisses { get; }
        public uint LastTotalAllocates { get; }
        public uint LastAllocateMisses { get; }
        public uint LastTotalFrees { get; }

        public _RTL_LOOKASIDE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_LOOKASIDE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_LOOKASIDE.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.Depth),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.MaximumDepth),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.TotalAllocates),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.AllocateMisses),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.TotalFrees),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.FreeMisses),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.LastTotalAllocates),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.LastAllocateMisses),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_LOOKASIDE.LastTotalFrees),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_RTL_LOOKASIDE>((mem, ptr) => new _RTL_LOOKASIDE(mem, ptr), offsets);
        }
    }
}