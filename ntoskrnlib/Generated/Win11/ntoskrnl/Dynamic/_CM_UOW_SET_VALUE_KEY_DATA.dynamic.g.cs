using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_UOW_SET_VALUE_KEY_DATA")]
    public sealed class _CM_UOW_SET_VALUE_KEY_DATA : DynamicStructure
    {
        public uint PreparedCell { get; }
        public uint OldValueCell { get; }
        public ushort NameLength { get; }
        public uint DataSize { get; }

        public _CM_UOW_SET_VALUE_KEY_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_UOW_SET_VALUE_KEY_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_UOW_SET_VALUE_KEY_DATA.PreparedCell),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_UOW_SET_VALUE_KEY_DATA.OldValueCell),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_UOW_SET_VALUE_KEY_DATA.NameLength),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_UOW_SET_VALUE_KEY_DATA.DataSize),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_CM_UOW_SET_VALUE_KEY_DATA>((mem, ptr) => new _CM_UOW_SET_VALUE_KEY_DATA(mem, ptr), offsets);
        }
    }
}