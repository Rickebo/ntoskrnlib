using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GENERAL_LOOKASIDE_POOL")]
    public sealed class _GENERAL_LOOKASIDE_POOL : DynamicStructure
    {
        public _SLIST_HEADER ListHead { get; }
        public _SINGLE_LIST_ENTRY SingleListHead { get; }
        public ushort Depth { get; }
        public ushort MaximumDepth { get; }
        public uint TotalAllocates { get; }
        public uint AllocateMisses { get; }
        public uint AllocateHits { get; }
        public uint TotalFrees { get; }
        public uint FreeMisses { get; }
        public uint FreeHits { get; }
        public uint Type { get; }
        public uint Tag { get; }
        public uint Size { get; }
        public IntPtr AllocateEx { get; }
        public IntPtr Allocate { get; }
        public IntPtr FreeEx { get; }
        public IntPtr Free { get; }
        public _LIST_ENTRY ListEntry { get; }
        public uint LastTotalAllocates { get; }
        public uint LastAllocateMisses { get; }
        public uint LastAllocateHits { get; }
        public uint[] Future { get; }

        public _GENERAL_LOOKASIDE_POOL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GENERAL_LOOKASIDE_POOL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.SingleListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.Depth),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.MaximumDepth),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.TotalAllocates),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.AllocateMisses),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.AllocateHits),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.TotalFrees),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.FreeMisses),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.FreeHits),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.Type),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.Tag),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.Size),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.AllocateEx),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.Allocate),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.FreeEx),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.Free),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.ListEntry),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.LastTotalAllocates),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.LastAllocateMisses),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.LastAllocateHits),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE_POOL.Future),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_GENERAL_LOOKASIDE_POOL>((mem, ptr) => new _GENERAL_LOOKASIDE_POOL(mem, ptr), offsets);
        }
    }
}