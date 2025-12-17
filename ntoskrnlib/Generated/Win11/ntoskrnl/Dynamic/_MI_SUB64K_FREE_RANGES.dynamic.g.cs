using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SUB64K_FREE_RANGES")]
    public sealed class _MI_SUB64K_FREE_RANGES : DynamicStructure
    {
        public _RTL_BITMAP_EX BitMap { get; }
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr Vad { get; }
        public uint SetBits { get; }
        public uint FullSetBits { get; }
        public uint SubListIndex { get; }
        public uint Hint { get; }

        public _MI_SUB64K_FREE_RANGES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SUB64K_FREE_RANGES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SUB64K_FREE_RANGES.BitMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SUB64K_FREE_RANGES.ListEntry),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SUB64K_FREE_RANGES.Vad),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_SUB64K_FREE_RANGES.SetBits),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_SUB64K_FREE_RANGES.FullSetBits),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MI_SUB64K_FREE_RANGES.SubListIndex),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_SUB64K_FREE_RANGES.Hint),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_MI_SUB64K_FREE_RANGES>((mem, ptr) => new _MI_SUB64K_FREE_RANGES(mem, ptr), offsets);
        }
    }
}