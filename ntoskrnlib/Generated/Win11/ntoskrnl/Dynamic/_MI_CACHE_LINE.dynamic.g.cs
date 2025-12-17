using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_CACHE_LINE")]
    public sealed class _MI_CACHE_LINE : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }
        public _unnamed_tag_ u2 { get; }

        public _MI_CACHE_LINE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_CACHE_LINE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_CACHE_LINE.u1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_CACHE_LINE.u2),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_CACHE_LINE>((mem, ptr) => new _MI_CACHE_LINE(mem, ptr), offsets);
        }
    }
}