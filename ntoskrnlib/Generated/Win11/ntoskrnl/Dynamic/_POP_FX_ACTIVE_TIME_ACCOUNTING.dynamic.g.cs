using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_ACTIVE_TIME_ACCOUNTING")]
    public sealed class _POP_FX_ACTIVE_TIME_ACCOUNTING : DynamicStructure
    {
        public ulong Total { get; }
        public ulong Unattributed { get; }
        public ulong[] Buckets { get; }
        public ulong[] PerBucket { get; }

        public _POP_FX_ACTIVE_TIME_ACCOUNTING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_ACTIVE_TIME_ACCOUNTING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_ACTIVE_TIME_ACCOUNTING.Total),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_ACTIVE_TIME_ACCOUNTING.Unattributed),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_ACTIVE_TIME_ACCOUNTING.Buckets),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_ACTIVE_TIME_ACCOUNTING.PerBucket),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_POP_FX_ACTIVE_TIME_ACCOUNTING>((mem, ptr) => new _POP_FX_ACTIVE_TIME_ACCOUNTING(mem, ptr), offsets);
        }
    }
}