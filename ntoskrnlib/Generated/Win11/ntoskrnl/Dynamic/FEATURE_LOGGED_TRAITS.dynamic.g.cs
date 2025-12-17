using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!FEATURE_LOGGED_TRAITS")]
    public sealed class FEATURE_LOGGED_TRAITS : DynamicStructure
    {
        public ushort version { get; }
        public ushort baseVersion { get; }
        public byte stage { get; }

        public FEATURE_LOGGED_TRAITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static FEATURE_LOGGED_TRAITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(FEATURE_LOGGED_TRAITS.version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(FEATURE_LOGGED_TRAITS.baseVersion),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(FEATURE_LOGGED_TRAITS.stage),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<FEATURE_LOGGED_TRAITS>((mem, ptr) => new FEATURE_LOGGED_TRAITS(mem, ptr), offsets);
        }
    }
}