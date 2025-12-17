using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_TYPE_ID")]
    public sealed class _WNF_TYPE_ID : DynamicStructure
    {
        public _GUID TypeId { get; }

        public _WNF_TYPE_ID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_TYPE_ID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_TYPE_ID.TypeId),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WNF_TYPE_ID>((mem, ptr) => new _WNF_TYPE_ID(mem, ptr), offsets);
        }
    }
}