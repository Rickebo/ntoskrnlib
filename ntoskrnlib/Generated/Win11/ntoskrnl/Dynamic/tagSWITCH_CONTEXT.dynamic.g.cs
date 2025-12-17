using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!tagSWITCH_CONTEXT")]
    public sealed class tagSWITCH_CONTEXT : DynamicStructure
    {
        public tagSWITCH_CONTEXT_ATTRIBUTE Attribute { get; }
        public tagSWITCH_CONTEXT_DATA Data { get; }

        public tagSWITCH_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static tagSWITCH_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(tagSWITCH_CONTEXT.Attribute),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT.Data),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<tagSWITCH_CONTEXT>((mem, ptr) => new tagSWITCH_CONTEXT(mem, ptr), offsets);
        }
    }
}