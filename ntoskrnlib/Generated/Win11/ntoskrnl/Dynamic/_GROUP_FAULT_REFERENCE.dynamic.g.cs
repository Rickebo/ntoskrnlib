using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GROUP_FAULT_REFERENCE")]
    public sealed class _GROUP_FAULT_REFERENCE : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }

        public _GROUP_FAULT_REFERENCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GROUP_FAULT_REFERENCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GROUP_FAULT_REFERENCE.u1),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_GROUP_FAULT_REFERENCE>((mem, ptr) => new _GROUP_FAULT_REFERENCE(mem, ptr), offsets);
        }
    }
}