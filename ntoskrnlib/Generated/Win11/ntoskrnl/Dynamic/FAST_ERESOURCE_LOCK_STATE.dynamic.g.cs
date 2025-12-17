using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!FAST_ERESOURCE_LOCK_STATE")]
    public sealed class FAST_ERESOURCE_LOCK_STATE : DynamicStructure
    {
        public long Value { get; }
        public long Exclusive { get; }
        public long Conflict { get; }
        public long ShareCount { get; }

        public FAST_ERESOURCE_LOCK_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static FAST_ERESOURCE_LOCK_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(FAST_ERESOURCE_LOCK_STATE.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(FAST_ERESOURCE_LOCK_STATE.Exclusive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(FAST_ERESOURCE_LOCK_STATE.Conflict),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(FAST_ERESOURCE_LOCK_STATE.ShareCount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<FAST_ERESOURCE_LOCK_STATE>((mem, ptr) => new FAST_ERESOURCE_LOCK_STATE(mem, ptr), offsets);
        }
    }
}