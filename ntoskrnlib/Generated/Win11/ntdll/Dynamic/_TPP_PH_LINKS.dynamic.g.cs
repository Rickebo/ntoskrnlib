using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_PH_LINKS")]
    public sealed class _TPP_PH_LINKS : DynamicStructure
    {
        public _LIST_ENTRY Siblings { get; }
        public _LIST_ENTRY Children { get; }
        public long Key { get; }

        public _TPP_PH_LINKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_PH_LINKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_PH_LINKS.Siblings),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_PH_LINKS.Children),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TPP_PH_LINKS.Key),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_TPP_PH_LINKS>((mem, ptr) => new _TPP_PH_LINKS(mem, ptr), offsets);
        }
    }
}