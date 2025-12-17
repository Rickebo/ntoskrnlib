using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!tagSWITCH_CONTEXT_DATA")]
    public sealed class tagSWITCH_CONTEXT_DATA : DynamicStructure
    {
        public ulong ullOsMaxVersionTested { get; }
        public uint ulTargetPlatform { get; }
        public ulong ullContextMinimum { get; }
        public _GUID guPlatform { get; }
        public _GUID guMinPlatform { get; }
        public uint ulContextSource { get; }
        public uint ulElementCount { get; }
        public byte[] guElements { get; }

        public tagSWITCH_CONTEXT_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static tagSWITCH_CONTEXT_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(tagSWITCH_CONTEXT_DATA.ullOsMaxVersionTested),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_DATA.ulTargetPlatform),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_DATA.ullContextMinimum),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_DATA.guPlatform),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_DATA.guMinPlatform),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_DATA.ulContextSource),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_DATA.ulElementCount),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(tagSWITCH_CONTEXT_DATA.guElements),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<tagSWITCH_CONTEXT_DATA>((mem, ptr) => new tagSWITCH_CONTEXT_DATA(mem, ptr), offsets);
        }
    }
}