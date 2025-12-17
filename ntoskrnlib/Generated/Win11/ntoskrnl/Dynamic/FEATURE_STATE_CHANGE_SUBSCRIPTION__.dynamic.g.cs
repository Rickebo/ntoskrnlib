using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!FEATURE_STATE_CHANGE_SUBSCRIPTION__")]
    public sealed class FEATURE_STATE_CHANGE_SUBSCRIPTION__ : DynamicStructure
    {
        public int unused { get; }

        public FEATURE_STATE_CHANGE_SUBSCRIPTION__(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static FEATURE_STATE_CHANGE_SUBSCRIPTION__()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(FEATURE_STATE_CHANGE_SUBSCRIPTION__.unused),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<FEATURE_STATE_CHANGE_SUBSCRIPTION__>((mem, ptr) => new FEATURE_STATE_CHANGE_SUBSCRIPTION__(mem, ptr), offsets);
        }
    }
}