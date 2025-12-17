using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_GENERAL_LOOKASIDE")]
    public sealed class _GENERAL_LOOKASIDE : DynamicStructure
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

        public _GENERAL_LOOKASIDE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GENERAL_LOOKASIDE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GENERAL_LOOKASIDE.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.SingleListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.Depth),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.MaximumDepth),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.TotalAllocates),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.AllocateMisses),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.AllocateHits),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.TotalFrees),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.FreeMisses),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.FreeHits),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.Type),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.Tag),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.Size),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.AllocateEx),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.Allocate),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.FreeEx),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.Free),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.ListEntry),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.LastTotalAllocates),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.LastAllocateMisses),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.LastAllocateHits),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_GENERAL_LOOKASIDE.Future),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_GENERAL_LOOKASIDE>((mem, ptr) => new _GENERAL_LOOKASIDE(mem, ptr), offsets);
        }
    }
}