using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_RUNDOWN_REF_CACHE_AWARE")]
    public sealed class _EX_RUNDOWN_REF_CACHE_AWARE : DynamicStructure
    {
        public IntPtr RunRefs { get; }
        public IntPtr PoolToFree { get; }
        public uint RunRefSize { get; }
        public uint Number { get; }

        public _EX_RUNDOWN_REF_CACHE_AWARE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_RUNDOWN_REF_CACHE_AWARE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_RUNDOWN_REF_CACHE_AWARE.RunRefs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_RUNDOWN_REF_CACHE_AWARE.PoolToFree),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EX_RUNDOWN_REF_CACHE_AWARE.RunRefSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EX_RUNDOWN_REF_CACHE_AWARE.Number),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_EX_RUNDOWN_REF_CACHE_AWARE>((mem, ptr) => new _EX_RUNDOWN_REF_CACHE_AWARE(mem, ptr), offsets);
        }
    }
}