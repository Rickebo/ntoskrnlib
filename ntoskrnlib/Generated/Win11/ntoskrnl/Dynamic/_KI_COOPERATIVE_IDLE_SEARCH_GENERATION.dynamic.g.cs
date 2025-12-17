using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_COOPERATIVE_IDLE_SEARCH_GENERATION")]
    public sealed class _KI_COOPERATIVE_IDLE_SEARCH_GENERATION : DynamicStructure
    {
        public _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID GenerationId { get; }
        public ushort AllocatedTargetEntries { get; }
        public ushort ActiveTargetEntries { get; }
        public uint Spare { get; }
        public byte[] ExtensionStart { get; }

        public _KI_COOPERATIVE_IDLE_SEARCH_GENERATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_COOPERATIVE_IDLE_SEARCH_GENERATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION.GenerationId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION.AllocatedTargetEntries),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION.ActiveTargetEntries),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION.Spare),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KI_COOPERATIVE_IDLE_SEARCH_GENERATION.ExtensionStart),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KI_COOPERATIVE_IDLE_SEARCH_GENERATION>((mem, ptr) => new _KI_COOPERATIVE_IDLE_SEARCH_GENERATION(mem, ptr), offsets);
        }
    }
}