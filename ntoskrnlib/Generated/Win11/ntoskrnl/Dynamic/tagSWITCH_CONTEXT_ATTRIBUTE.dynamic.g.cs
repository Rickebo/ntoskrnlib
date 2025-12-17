using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!tagSWITCH_CONTEXT_ATTRIBUTE")]
    public sealed class tagSWITCH_CONTEXT_ATTRIBUTE : DynamicStructure
    {
        public ulong ulContextUpdateCounter { get; }
        public int fAllowContextUpdate { get; }
        public int fEnableTrace { get; }
        public ulong EtwHandle { get; }

        public tagSWITCH_CONTEXT_ATTRIBUTE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static tagSWITCH_CONTEXT_ATTRIBUTE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(tagSWITCH_CONTEXT_ATTRIBUTE.ulContextUpdateCounter),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_ATTRIBUTE.fAllowContextUpdate),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_ATTRIBUTE.fEnableTrace),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_ATTRIBUTE.EtwHandle),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<tagSWITCH_CONTEXT_ATTRIBUTE>((mem, ptr) => new tagSWITCH_CONTEXT_ATTRIBUTE(mem, ptr), offsets);
        }
    }
}