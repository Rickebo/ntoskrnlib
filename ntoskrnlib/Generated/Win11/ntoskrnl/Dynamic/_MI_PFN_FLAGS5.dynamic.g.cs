using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PFN_FLAGS5")]
    public sealed class _MI_PFN_FLAGS5 : DynamicStructure
    {
        public uint EntireField { get; }
        public _unnamed_tag_ StandbyList { get; }
        public _unnamed_tag_ MappedPageList { get; }
        public _unnamed_tag_ Active { get; }

        public _MI_PFN_FLAGS5(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PFN_FLAGS5()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PFN_FLAGS5.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS5.StandbyList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS5.MappedPageList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PFN_FLAGS5.Active),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_PFN_FLAGS5>((mem, ptr) => new _MI_PFN_FLAGS5(mem, ptr), offsets);
        }
    }
}