using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_UOW_SET_VALUE_LIST_DATA")]
    public sealed class _CM_UOW_SET_VALUE_LIST_DATA : DynamicStructure
    {
        public uint RefCount { get; }
        public _CHILD_LIST ValueList { get; }

        public _CM_UOW_SET_VALUE_LIST_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_UOW_SET_VALUE_LIST_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_UOW_SET_VALUE_LIST_DATA.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_UOW_SET_VALUE_LIST_DATA.ValueList),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CM_UOW_SET_VALUE_LIST_DATA>((mem, ptr) => new _CM_UOW_SET_VALUE_LIST_DATA(mem, ptr), offsets);
        }
    }
}