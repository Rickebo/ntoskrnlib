using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PTE_TRACKER")]
    public sealed class _PTE_TRACKER : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr Mdl { get; }
        public ulong Count { get; }
        public IntPtr SystemVa { get; }
        public IntPtr StartVa { get; }
        public uint Offset { get; }
        public uint Length { get; }
        public ulong Page { get; }
        public uint IoMapping { get; }
        public uint Matched { get; }
        public uint CacheAttribute { get; }
        public uint GuardPte { get; }
        public uint Spare { get; }
        public byte[] StackTrace { get; }

        public _PTE_TRACKER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PTE_TRACKER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PTE_TRACKER.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.Mdl),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.Count),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.SystemVa),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.StartVa),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.Offset),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.Length),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.Page),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.IoMapping),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.Matched),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.CacheAttribute),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.GuardPte),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.Spare),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PTE_TRACKER.StackTrace),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_PTE_TRACKER>((mem, ptr) => new _PTE_TRACKER(mem, ptr), offsets);
        }
    }
}