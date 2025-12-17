using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID")]
    public sealed class _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID : DynamicStructure
    {
        public ulong FullId { get; }
        public ulong Empty { get; }
        public ulong MinorId { get; }
        public ulong MajorId { get; }

        public _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID.FullId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID.Empty),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID.MinorId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID.MajorId),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID>((mem, ptr) => new _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID(mem, ptr), offsets);
        }
    }
}