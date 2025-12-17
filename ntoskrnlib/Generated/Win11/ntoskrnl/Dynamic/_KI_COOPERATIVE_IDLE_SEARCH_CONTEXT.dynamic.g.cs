using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT")]
    public sealed class _KI_COOPERATIVE_IDLE_SEARCH_CONTEXT : DynamicStructure
    {
        public ulong SearchContextLock { get; }
        public ulong SearchingProcessors { get; }
        public _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID NextGenerationId { get; }
        public byte[] GenerationIds { get; }
        public byte[] Generations { get; }
        public ulong Affinity { get; }
        public ushort AllocatedTargetEntries { get; }
        public ushort ActiveTargetEntries { get; }
        public byte LowProcIndex { get; }
        public byte HighProcIndex { get; }
        public ushort Group { get; }
        public byte[] ExtensionStart { get; }

        public _KI_COOPERATIVE_IDLE_SEARCH_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_COOPERATIVE_IDLE_SEARCH_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.SearchContextLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.SearchingProcessors),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.NextGenerationId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.GenerationIds),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.Generations),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.Affinity),
                    new ulong[]
                    {
                        1048UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.AllocatedTargetEntries),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.ActiveTargetEntries),
                    new ulong[]
                    {
                        1058UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.LowProcIndex),
                    new ulong[]
                    {
                        1060UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.HighProcIndex),
                    new ulong[]
                    {
                        1061UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.Group),
                    new ulong[]
                    {
                        1062UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT.ExtensionStart),
                    new ulong[]
                    {
                        1064UL
                    }
                }
            };
            Register<_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT>((mem, ptr) => new _KI_COOPERATIVE_IDLE_SEARCH_CONTEXT(mem, ptr), offsets);
        }
    }
}